using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PS_FishTankApp_M02.Models;
using PS_FishTankApp_M02.Services;

// 01/16/2021 12:21 pm - SSN - [20210116-1157] - [003] - M03-07 - Creating a web API.

namespace PS_FishTankApp_M02.Controllers.API
{
    // [Route("api/[controller]")]
    // [ApiController]
    // public class HistoryDataController : ControllerBase
    public class HistoryDataController : Controller
    {
        private readonly ISensorDataService sensorDataService;

        public HistoryDataController( ISensorDataService sensorDataService)
        {
            this.sensorDataService = sensorDataService;
        }

        public IEnumerable<IntHistoryModel> GetWaterTemperatureHistory()
        {
            return sensorDataService.GetWaterTemperatureFahrenheitHistory();
        }

        public IEnumerable<IntHistoryModel> GetWaterOpacityPercentageHistory()
        {
            return sensorDataService.GetWaterOpacityPercentageHistory();
        }
        public IEnumerable<IntHistoryModel> GetFishMotionPercentageHistory()
        {
            return sensorDataService.GetFishMotionPercentageHistory();
        }

        public IEnumerable<IntHistoryModel> GetLightIntensityLumensHistory()
        {
            return sensorDataService.GetLightIntensityLumensHistory();
        }

    }
}