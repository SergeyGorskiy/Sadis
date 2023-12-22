using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sadis.DAL.Data;
using Sadis.Entities.Models;
using Sadis.Entities.ViewModels;
using System.Drawing;

namespace Sadis.Web.Areas.Operator.Controllers
{
    public class RoadObjectsController : Controller
    {
        private readonly ILogger<RoadObjectsController> _logger;
        private readonly SmetaContext _smetaContext;

        public RoadObjectsController(SmetaContext smetaContext, ILogger<RoadObjectsController> logger)
        {
            _smetaContext = smetaContext;
            _logger = logger;
        }

        public async Task<IActionResult>  Index()
        {
            var objects = await _smetaContext.DObjects
                .Select(o => new
                {
                    C_OBJECT = o.CObject,
                    C_TYPE_OBJECT = o.CTypeObject,
                    N_TYPE_OBJECT = o.CTypeObjectNavigation.NTypeObject,
                    N_OBJECT = o.NObject,
                    CODE = o.Code,
                    BEGKM = o.Begkm,
                    ENDKM = o.Endkm,
                    ENABLED_FOR_JORNAL = o.EnabledForJornal,
                    C_REGION = o.CRegion,
                    N_REGION = o.CRegionNavigation.NRegion,
                    C_ROAD = o.CRoad,
                    N_ROAD = o.CRoadNavigation.NRoad,
                    ROAD_BEGKM = o.CRoadNavigation.Begkm,
                    ROAD_ENDKM = o.CRoadNavigation.Endkm,
                    ROAD_CODE = o.CRoadNavigation.Code,
                    C_EXPL_CATEGORY = o.CExplCategory,
                    N_EXPL_CATEGORY = o.CExplCategoryNavigation.NExplCategory,
                    C_STATUS_OBJECT = o.CStatusObject,
                    C_TYPE_BRIDGE = o.CTypeBridge,
                    C_BRIDGE_MATERIAL = o.CBridgeMaterial
                }).AsNoTracking().ToListAsync();

            var typeObjects = await _smetaContext.STypeObjects
                .Select(t => new STypeObject
                {
                    CTypeObject = t.CTypeObject,
                    NTypeObject = t.NTypeObject
                }).AsNoTracking().ToListAsync();

            var explCategories = await _smetaContext.SExplCategories
                .Select(t => new SExplCategory
                {
                    CExplCategory = t.CExplCategory,
                    NameExplCategory = t.NameExplCategory
                }).AsNoTracking().ToListAsync();

            var statuses = await _smetaContext.SStatusObjects
                .Select(t => new SStatusObject
                {
                    CStatusObject = t.CStatusObject,
                    NStatusObject = t.NStatusObject
                }).AsNoTracking().ToListAsync();

            var bridgeTypes = await _smetaContext.STypeBridges
                .Select(t => new STypeBridge
                {
                    CTypeBridge = t.CTypeBridge,
                    NTypeBridge = t.NTypeBridge
                }).AsNoTracking().ToListAsync();

            var bridgeMaterials = await _smetaContext.SBridgeMaterials
                .Select(t => new SBridgeMaterial
                {
                    CBridgeMaterial = t.CBridgeMaterial,
                    NBridgeMaterial = t.NBridgeMaterial
                }).AsNoTracking().ToListAsync();

            List<RoadObjectsVM> objectsVMs = new();
            if (objects.Any())
            {
                //string input = "http://www.somesite.com/somepage.aspx?whatever";
                //int index = input.IndexOf("?");
                //if (index >= 0) input = input.Substring(0, index + 4);

                objectsVMs = objects.Select(o => new RoadObjectsVM
                {
                    C_OBJECT = o.C_OBJECT,
                    N_OBJECT = o.N_OBJECT,
                    CODE = o.CODE,
                    BEGKM = o.BEGKM,
                    ENDKM = o.ENDKM,
                    ENABLED_FOR_JORNAL = o.ENABLED_FOR_JORNAL == 1,
                    ENABLED_FOR_JORNAL_STR = o.ENABLED_FOR_JORNAL == 1 ? "ДА" : "НЕТ",
                    C_REGION = o.C_REGION,
                    N_REGION = o.N_REGION,
                    C_ROAD = o.C_ROAD,
                    N_ROAD = o.N_ROAD,
                    NAME_ROAD = $"{o.ROAD_CODE} {o.N_ROAD} ({o.ROAD_BEGKM} - {o.ROAD_ENDKM} км)",
                    C_TYPE_OBJECT = o.C_TYPE_OBJECT,
                    N_TYPE_OBJECT = o.N_TYPE_OBJECT,
                    C_EXPL_CATEGORY = o.C_EXPL_CATEGORY,
                    N_EXPL_CATEGORY = o.N_EXPL_CATEGORY,
                    C_STATUS_OBJECT = o.C_STATUS_OBJECT,
                    C_TYPE_BRIDGE = o.C_TYPE_BRIDGE,
                    C_BRIDGE_MATERIAL = o.C_BRIDGE_MATERIAL
                }).ToList();
            }

            var regions = objectsVMs.Select(vm => new { vm.C_REGION, vm.N_REGION }).Distinct();
            var roads = objectsVMs.Select(vm => new { vm.C_ROAD, vm.NAME_ROAD }).Distinct();
            RoadObjectsFullVM objectsFullVM = new()
            {
                ObjectVM = new RoadObjectsVM(),
                TypeObjects = new SelectList(typeObjects, "CTypeObject", "NTypeObject"),
                Regions = new SelectList(regions, "C_REGION", "N_REGION"),
                Roads = new SelectList(roads, "C_ROAD", "NAME_ROAD"),
                ExplCategories = new SelectList(explCategories, "CExplCategory", "NameExplCategory"),
                Statuses = new SelectList(statuses, "CStatusObject", "NStatusObject"),
                BridgeTypes = new SelectList(bridgeTypes, "CTypeBridge", "NTypeBridge"),
                BridgeMaterials = new SelectList(bridgeMaterials, "CBridgeMaterial", "NBridgeMaterial"),
                ObjectVMs = objectsVMs
            };

            return View(objectsFullVM);
        }

        [HttpPost]
        public async Task<IActionResult> Upsert(RoadObjectsVM objectVm)
        {
            if (ModelState.IsValid)
            {
                if (objectVm.C_OBJECT == 0)
                {
                    DObject dObject = new ();
                    dObject.CBridgeObject = objectVm.C_BRIDGE_OBJECT;
                    dObject.CTypeObject = objectVm.C_TYPE_OBJECT;
                    dObject.CRegion = objectVm.C_REGION;
                    dObject.CRoad = objectVm.C_ROAD;
                    dObject.CStatusObject = objectVm.C_STATUS_OBJECT;
                    dObject.CExplCategory = objectVm.C_EXPL_CATEGORY;
                    dObject.CTypeBridge = objectVm.C_TYPE_BRIDGE;
                    dObject.CBridgeMaterial = objectVm.C_BRIDGE_MATERIAL;
                    dObject.NObject = objectVm.N_OBJECT;
                    dObject.Code = objectVm.CODE;
                    dObject.Barrier = objectVm.BARRIER;
                    dObject.Gabarit = objectVm.GABARIT;
                    dObject.DateLeadIn = objectVm.DATE_LEAD_IN;
                    dObject.DateLeadOut = objectVm.DATE_LEAD_OUT;
                    dObject.Length = objectVm.LENGTH;
                    dObject.Mp = objectVm.MP;
                    dObject.Coef = objectVm.COEF;
                    dObject.Begkm = objectVm.BEGKM;
                    dObject.Endkm = objectVm.ENDKM;
                    dObject.BegkmStolb = objectVm.BEGKM_STOLB;
                    dObject.EndkmStolb = objectVm.ENDKM_STOLB;
                    dObject.NBridgeLet = objectVm.N_BRIDGE_LET;
                    dObject.EnabledForJornal = Convert.ToByte(objectVm.ENABLED_FOR_JORNAL);
                    int id = _smetaContext.DObjects.Max(o => o.CObject) + 1;
                    dObject.CObject = id;
                    _smetaContext.DObjects.Add(dObject);
                    await _smetaContext.SaveChangesAsync();
                }
                else
                {
                    var dObject = await _smetaContext.DObjects.FirstOrDefaultAsync(o => o.CObject == objectVm.C_OBJECT);
                    if (dObject == null) return NotFound();
                    dObject.CBridgeObject = objectVm.C_BRIDGE_OBJECT;
                    dObject.CTypeObject = objectVm.C_TYPE_OBJECT;
                    dObject.CRegion = objectVm.C_REGION;
                    dObject.CRoad = objectVm.C_ROAD;
                    dObject.CStatusObject = objectVm.C_STATUS_OBJECT;
                    dObject.CExplCategory = objectVm.C_EXPL_CATEGORY;
                    dObject.CTypeBridge = objectVm.C_TYPE_BRIDGE;
                    dObject.CBridgeMaterial = objectVm.C_BRIDGE_MATERIAL;
                    dObject.NObject = objectVm.N_OBJECT;
                    dObject.Code = objectVm.CODE;
                    dObject.Barrier = objectVm.BARRIER;
                    dObject.Gabarit = objectVm.GABARIT;
                    dObject.DateLeadIn = objectVm.DATE_LEAD_IN;
                    dObject.DateLeadOut = objectVm.DATE_LEAD_OUT;
                    dObject.Length = objectVm.LENGTH;
                    dObject.Mp = objectVm.MP;
                    dObject.Coef = objectVm.COEF;
                    dObject.Begkm = objectVm.BEGKM;
                    dObject.Endkm = objectVm.ENDKM;
                    dObject.BegkmStolb = objectVm.BEGKM_STOLB;
                    dObject.EndkmStolb = objectVm.ENDKM_STOLB;
                    dObject.NBridgeLet = objectVm.N_BRIDGE_LET;
                    dObject.EnabledForJornal = Convert.ToByte(objectVm.ENABLED_FOR_JORNAL);
                    await _smetaContext.SaveChangesAsync();
                }
            }

            return RedirectToAction("Index");
        }
    }
}
