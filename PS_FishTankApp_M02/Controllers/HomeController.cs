using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PS_FishTankApp_M02.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

// 01/15/2021 12:38 pm - SSN - [20210115-1233] - [001] - M03-04 - Unified controllers

namespace PS_FishTankApp_M02.Controllers
{
    public class HomeController : Controller
    {
        private readonly IViewModelService viewModelService;

        public HomeController(IViewModelService viewModelService)
        {
            this.viewModelService = viewModelService;
        }


        // GET: /<controller>/
        public IActionResult Index()
        {

            ViewBag.Title = "Fish Tank Dashboard";
            return View(viewModelService.GetDashboardViewModel());
        }
    }
}
