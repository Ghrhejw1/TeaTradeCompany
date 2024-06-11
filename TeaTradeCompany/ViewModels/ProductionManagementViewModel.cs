using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.ObjectModel;
using TeaTradeCompany.Model;

namespace TeaTradeCompany.ViewModels
{
    public class ProductionManagementViewModel : BaseViewModel
    {
        public ObservableCollection<Параметры_климата> ClimateParameters { get; set; }
        public ObservableCollection<Технологический_Процесс> ProcessingSteps { get; set; }
        public ObservableCollection<Участок> PlantationPlots { get; set; }

        public ProductionManagementViewModel()
        {
            // Заполнение коллекций данными
            ClimateParameters = new ObservableCollection<Параметры_климата>
            {
                new Параметры_климата { Температура = 20, Влажность = 60, Осадки = 5, Дата_измерения = DateTime.Now }
            };

            ProcessingSteps = new ObservableCollection<Технологический_Процесс>
            {
                new Технологический_Процесс { Название = "Ферментация", Описание = "Процесс ферментации чая." }
            };

            PlantationPlots = new ObservableCollection<Участок>
            {
                new Участок { Название = "Участок 1", Площадь = 10, Тип_растений = "Зеленый чай" }
            };
        }
    }
}
