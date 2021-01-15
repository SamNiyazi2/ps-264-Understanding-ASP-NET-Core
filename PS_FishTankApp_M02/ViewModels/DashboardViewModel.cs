using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// 01/15/2021 12:42 pm - SSN - [20210115-1233] - [003] - M03-04 - Unified controllers

namespace PS_FishTankApp_M02.ViewModels
{
    public class DashboardViewModel
    {
        public SensorTileViewModel WaterTempreatureTile { get; set; }
        public SensorTileViewModel FishMotionTile { get; set; }
        public SensorTileViewModel WaterOpacityTile { get; set; }
        public SensorTileViewModel LightIntensityTile { get; set; }

    }
}
