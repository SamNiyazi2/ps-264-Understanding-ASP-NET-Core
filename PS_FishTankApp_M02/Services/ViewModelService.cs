using Microsoft.AspNetCore.Mvc;
using PS_FishTankApp_M02.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// 01/15/2021 12:44 pm - SSN - [20210115-1233] - [004] - M03-04 - Unified controllers

namespace PS_FishTankApp_M02.Services
{
    public class ViewModelService : IViewModelService
    {
        private readonly ISensorDataService sensorDataService;
        private readonly IUrlHelper urlHelper;

        public ViewModelService(ISensorDataService sensorDataService, IUrlHelper urlHelper)
        {
            this.sensorDataService = sensorDataService;
            this.urlHelper = urlHelper;
        }

        public DashboardViewModel GetDashboardViewModel()
        {
            return new DashboardViewModel
            {

                WaterTempreatureTile = new SensorTileViewModel
                {
                    Title = "Water Temperature",
                    Value = sensorDataService.GetWaterTemperatureFahrenheit().Value,
                    ColorCssClass = "panel-blue",
                    IconCssClass = "fa-sliders-h ",
                    Url = urlHelper.Action("GetWaterTemeratureChart", "History")
                }
,
                FishMotionTile = new SensorTileViewModel
                {
                    Title = "Motion",
                    Value = sensorDataService.GetFishMotionPercentage().Value,
                    ColorCssClass = "panel-green",
                    IconCssClass = "fa-car",
                    Url = urlHelper.Action("GetFishMotionPercentageChart", "History")
                },

                WaterOpacityTile = new SensorTileViewModel
                {
                    Title = "Water Opacity ",
                    Value = sensorDataService.GetWaterOpacityPercentage().Value,
                    ColorCssClass = "panel-yellow",
                    IconCssClass = "fa-adjust",
                    Url = urlHelper.Action("GetWaterOpacityTileChart", "History")
                },

                LightIntensityTile = new SensorTileViewModel
                {
                    Title = "Light Intensity",
                    Value = sensorDataService.GetLightIntencityLumens().Value,
                    ColorCssClass = "panel-red",
                    IconCssClass = "fa-lightbulb",
                    Url = urlHelper.Action("GetLightIntencityLumensChart", "History")
                }

            };
        }

    }
}
