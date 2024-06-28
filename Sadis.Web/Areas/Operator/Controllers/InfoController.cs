using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sadis.DAL.Data;
using Sadis.Entities.ViewModels;

namespace Sadis.Web.Areas.Operator.Controllers
{
    public class InfoController : Controller
    {
        private readonly ILogger<InfoController> _logger;
        private readonly SmetaContext _smetaContext;
        public InfoController(ILogger<InfoController> logger, SmetaContext smetaContext)
        {
            _logger = logger;
            _smetaContext = smetaContext;
        }
        public async Task<IActionResult> Index()
        {
            var contracts = await _smetaContext.DContracts
                .Select(c => new {
                    C_CONTRACT = c.CContract,
                    N_CONTRACT = c.NContract,
                    N_BLOCK = c.NBlock,
                    C_CONTRACTOR = c.CContractor,
                    N_CONTRACTOR = c.CContractorNavigation.NContractor,
                    C_GENERAL_CONTRACT = c.CGeneralContract,
                    N_GENERAL_CONTRACT = c.CGeneralContractNavigation.NGeneralContract,
                    NUMB_GENERAL_CONTRACT = c.CGeneralContractNavigation.Number,
                    C_GENERAL_CONTRACTOR = c.CGeneralContractNavigation.CGeneralContractor,
                    N_GENERAL_CONTRACTOR = c.CGeneralContractNavigation.CGeneralContractorNavigation == null ? "" 
                                           : c.CGeneralContractNavigation.CGeneralContractorNavigation.NGeneralContractor
                }).AsNoTracking().ToListAsync();

            List<InfoVM> model = new();
            if (contracts.Any())
            {
                model = contracts.Select(c => new InfoVM
                {
                    C_CONTRACT = c.C_CONTRACT,
                    N_CONTRACT = c.N_CONTRACT,
                    N_BLOCK = c.N_BLOCK,
                    C_CONTRACTOR = c.C_CONTRACTOR,
                    N_CONTRACTOR = c.N_CONTRACTOR,
                    C_GENERAL_CONTRACT = c.C_GENERAL_CONTRACT,
                    N_GENERAL_CONTRACT = c.NUMB_GENERAL_CONTRACT + " " + c.N_GENERAL_CONTRACT,
                    C_GENERAL_CONTRACTOR = c.C_GENERAL_CONTRACTOR,
                    N_GENERAL_CONTRACTOR = c.N_GENERAL_CONTRACTOR
                }).OrderBy(vm => vm.N_BLOCK).ThenBy(vm => vm.N_CONTRACTOR).ToList();
            }

            return View(model);
        }
    }
}
