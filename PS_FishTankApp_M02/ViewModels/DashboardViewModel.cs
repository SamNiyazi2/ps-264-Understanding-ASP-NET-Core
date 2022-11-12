using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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


        // 01/16/2021 03:38 am - SSN - [20210116-0006] - [001] - M03-06 - More tag helpers 

        [Display(Name = "Pleae enter the food amount:")]
        public int FoodAmount { get; set; }

        [Display(Name = "Last feeding was at: ")]
        public string LastFed { get; set; }




    }
}
