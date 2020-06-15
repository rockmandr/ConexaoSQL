using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SqlCsharp.Models;
using SqlCsharp.Services;

namespace SqlCsharp.Controllers
{
    [Route("Correntista")]
    public class CorrentistaController : Controller
    {
        private Context _conexaoDB;

        public CorrentistaController(Context conexaoDB)
        {
            _conexaoDB = conexaoDB;
        }

        List<CorrentistaService> correntistas = CorrentistaService.GetCorrentistaServices();

        [Route("")]
        [Route("~/")]
        [Route("index")]
        public IActionResult Index()
        {
            ViewBag.corrent = correntistas.ToList();
            return View();
        }
    }
}