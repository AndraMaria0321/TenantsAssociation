using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjectApp.Interfaces;
using ProjectApp.Models;
using ProjectWebApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectWebApp.Controllers
{
    public class HomeController : Controller
    {
        private IInvoice invoices;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IInvoice invoices)
        {
            _logger = logger;

            this.invoices = invoices;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }

        public IActionResult SignIn()
        {
            return View();
        }

        public IActionResult ProfileUser()
        {
            return View();
        }

        public IActionResult ProfileAdmin()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Profile()
        {
            return View();
        }
        [HttpPost]
        public IActionResult GetDetails()
        {
            Invoice umodel = new Invoice();
            umodel.Name = HttpContext.Request.Form["txtName"].ToString();
            umodel.ApartmentNo = Convert.ToInt32(HttpContext.Request.Form["txtApNumber"]);
            umodel.Price = Convert.ToInt32(HttpContext.Request.Form["txtPrice"]);
            umodel.DueDate = Convert.ToDateTime(HttpContext.Request.Form["txtDate"]);
            umodel.Description = HttpContext.Request.Form["txtDescription"].ToString();
            this.invoices.SaveDetails(umodel);

            return View();
        }
    }
}
