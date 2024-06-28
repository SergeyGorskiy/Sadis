using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sadis.DAL.Data;
using Sadis.Entities.Models;
using Sadis.Entities.ViewModels;

namespace Sadis.Web.Areas.Operator.Controllers
{
    public class RoadObjectRegionController : Controller
    {
        private readonly ILogger<RoadObjectRegionController> _logger;
        private readonly SmetaContext _smetaContext;

        public RoadObjectRegionController(SmetaContext smetaContext, ILogger<RoadObjectRegionController> logger)
        {
            _smetaContext = smetaContext;
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            var regions = await _smetaContext.SRegions.Select(r => new
            {
                C_REGION = r.CRegion,
                N_REGION = r.NRegion,
                COEF_SALARY = r.CoefSalary,
                C_CLIMAT_ZONE = r.CClimatZone,
                N_CLIMAT_ZONE = r.CClimatZoneNavigation.NClimatZone
            }).AsNoTracking().ToListAsync();

            var climateZones = await _smetaContext.SClimatZones.Select(c => new SClimatZone
            {
                CClimatZone = c.CClimatZone,
                NClimatZone = c.NClimatZone
            }).AsNoTracking().ToListAsync();

            List<RoadObjectRegionVM> regionVMs = new();
            if (regions.Any())
            {
                regionVMs = regions.Select(r => new RoadObjectRegionVM
                {
                    C_REGION = r.C_REGION,
                    N_REGION = r.N_REGION,
                    COEF_SALARY = r.COEF_SALARY, 
                    C_CLIMAT_ZONE = r.C_CLIMAT_ZONE,
                    N_CLIMAT_ZONE = r.N_CLIMAT_ZONE
                }).ToList();
            }

            RoadObjectRegionFullVM regionsFullVM = new()
            {
                RegionVM = new RoadObjectRegionVM(),
                RegionVMs = regionVMs,
                ClimateZones = new SelectList(climateZones, "CClimatZone", "NClimatZone")
            };

            return View(regionsFullVM);
        }
    }
}
