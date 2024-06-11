using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaTradeCompany.ViewModels
{
    public class BusinessSolutionsSupportViewModel : BaseViewModel
    {
        private ObservableCollection<string> _businessSolutions;

        public ObservableCollection<string> BusinessSolutions
        {
            get => _businessSolutions;
            set
            {
                _businessSolutions = value;
                OnPropertyChanged(nameof(BusinessSolutions));
            }
        }

        public BusinessSolutionsSupportViewModel()
        {
            LoadBusinessSolutions();
        }

        private void LoadBusinessSolutions()
        {
            BusinessSolutions = new ObservableCollection<string>
            {
                "Анализ рынка и конкурентов",
                "Формирование маркетинговой стратегии",
                "Разработка бизнес-планов",
                "Управление бюджетом и финансовый анализ",
                "Оптимизация производственных процессов",
                "Консалтинг по управлению персоналом",
                "Внедрение информационных систем",
                "Стратегическое партнерство и альянсы",
                "Управление рисками и обеспечение безопасности"
            };
        }
    }
}
