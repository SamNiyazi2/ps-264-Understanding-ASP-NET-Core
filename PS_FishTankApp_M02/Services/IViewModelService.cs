using PS_FishTankApp_M02.ViewModels;

// 01/15/2021 12:47 pm - SSN - [20210115-1233] - [005] - M03-04 - Unified controllers

namespace PS_FishTankApp_M02.Services
{
    public interface IViewModelService
    {
        DashboardViewModel GetDashboardViewModel();
    }
}