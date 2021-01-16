using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// 01/16/2021 02:49 pm - SSN - [20210116-1432] - [001] - M03-08 - Application settings

namespace PS_FishTankApp_M02.Options
{
    public class ThresholdOptions
    {

        public int WaterTemperatureMin  { get; set; }
        public int WaterTemperatureMax { get; set; }
        public int FishMotionMin { get; set; }
        public int FishMotionMax { get; set; }
        public int WaterOpacityMin { get; set; }
        public int WaterOpacityMax { get; set; }
        public int LightIntensityMin { get; set; }
        public int LightIntensityMax  { get; set; }

    }
}
