using System.Collections.ObjectModel;

namespace TeaTradeCompany.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public ObservableCollection<BaseViewModel> ViewModels { get; set; }

        public MainViewModel()
        {
            ViewModels = new ObservableCollection<BaseViewModel>
            {
                new ProductionManagementViewModel(),
                new LogisticsAndSupplyChainManagementViewModel(),
                new SalesAndOrdersManagementViewModel(),
                new PersonnelAndDepartmentsManagementViewModel(),
                new AnalyticsAndReportingViewModel(),
                new BusinessSolutionsSupportViewModel()
            };
        }
    }
}