using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using TeaTradeCompany.Model;

namespace TeaTradeCompany.ViewModels
{
    public class AnalyticsAndReportingViewModel : BaseViewModel
    {
        private ObservableCollection<Департамент> _departments;
        private string _selectedReportType;

        public ObservableCollection<Департамент> Departments
        {
            get => _departments;
            set
            {
                _departments = value;
                OnPropertyChanged(nameof(Departments));
            }
        }

        public string SelectedReportType
        {
            get => _selectedReportType;
            set
            {
                _selectedReportType = value;
                OnPropertyChanged(nameof(SelectedReportType));
                FilterReports(); // Вызываем метод фильтрации при изменении выбранного типа отчета
            }
        }

        public AnalyticsAndReportingViewModel()
        {
            LoadDepartments();
        }

        private void LoadDepartments()
        {
            using (var dbContext = new ApplicationDbContext())
            {
                // Загружаем данные о департаментах из базы данных
                var departmentsFromDb = dbContext.Департамент.ToList();

                // Преобразуем список департаментов в ObservableCollection
                Departments = new ObservableCollection<Департамент>(departmentsFromDb);
            }
        }

        private void FilterReports()
        {
            // Проверяем, выбран ли тип отчета
            if (!string.IsNullOrEmpty(SelectedReportType))
            {
                using (var dbContext = new ApplicationDbContext())
                {
                    // Загружаем данные о департаментах из базы данных
                    var departmentsFromDb = dbContext.Департамент
                        .Where(d => d.Отчёт == SelectedReportType) // Фильтруем по типу отчета
                        .ToList();

                    // Преобразуем отфильтрованный список департаментов в ObservableCollection
                    Departments = new ObservableCollection<Департамент>(departmentsFromDb);
                }
            }
            else
            {
                // Если тип отчета не выбран, загружаем все департаменты
                LoadDepartments();
            }
        }
    }
}


