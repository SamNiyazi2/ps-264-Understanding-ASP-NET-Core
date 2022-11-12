using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PS_FishTankApp_M02.ViewModels;

// 01/16/2021 12:10 pm - SSN - [20210116-1157] - [002] - M03-07 - Creating a web API.

namespace PS_FishTankApp_M02.Controllers
{
    public class HistoryController : Controller
    {
        public IActionResult GetWaterTemperatureChart()
        {
            return getViewRequest("Water Temperature", "GetWaterTemperatureHistory");
        }


        public IActionResult GetFishMotionPercentageChart()
        {
            //Todo
            return getViewRequest("Fish Motion", "GetFishMotionPercentageHistory");
        }


        public IActionResult GetWaterOpacityPercentageChart()
        {
            return getViewRequest("Water Opacity", "GetWaterOpacityPercentageHistory");
        }

        public IActionResult GetLightIntensityLumensChart()
        {
            return getViewRequest("Light Intensity", "GetLightIntensityLumensHistory");
        }


        private IActionResult getViewRequest(string title, string actionName)
        {
            // string debugUrl = Url.Action(actionName, "HistoryData");
            string url= string.Format("/HistoryData/{0}", actionName);

            return View("chart", new ChartViewModel
            {
                Title = title,
                DataUrl = url
            });
        }
    }
}