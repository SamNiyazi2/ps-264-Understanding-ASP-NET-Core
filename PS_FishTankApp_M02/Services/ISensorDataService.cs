using PS_FishTankApp_M02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// 01/15/2021 06:17 am - SSN - [20210115-0605] - [003] - M02-06 - The startup class

namespace PS_FishTankApp_M02.Services
{
    public interface ISensorDataService
    {

        IntHistoryModel GetWaterTemperaturFahrenheit();

        IEnumerable<IntHistoryModel> GetWaterTemperatureFahrenheitHistory();

        IntHistoryModel GetFishMotionPercentage();

        IEnumerable<IntHistoryModel> GetFishMotionPercentageHistory();


        IntHistoryModel GetWaterOpacityPercentage();

        IEnumerable<IntHistoryModel> GetWaterOpacityPercentageHistory();

        IntHistoryModel GetLightIntencityLumens();

        IEnumerable<IntHistoryModel> GetLightIntensityLumensHistory();

    }
}
