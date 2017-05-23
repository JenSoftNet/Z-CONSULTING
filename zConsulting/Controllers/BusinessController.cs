using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using zConsulting.Models.Business;

namespace zConsulting.Controllers
{
    [Route("[controller]")]
    public class BusinessController : Controller
    {
        private readonly IStringLocalizer<HomeController> _localizer;

        public BusinessController(IStringLocalizer<HomeController> localizer)
        {
            _localizer = localizer;
        }

        [Route("Outsourcing")]
        public IActionResult Outsourcing()
        {
            var outsourcingModel = new OutsourcingViewModel();
            return View(outsourcingModel);
        }
        [Route("Accounting")]
        public IActionResult Accounting()
        {
            return View();
        }
        [Route("Outstaffing")]
        public IActionResult Outstaffing()
        {
            var outstaffing = new OutstaffingViewModel();
            return View(outstaffing);
        }
    }
}