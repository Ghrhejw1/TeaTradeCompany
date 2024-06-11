using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.ObjectModel;
using TeaTradeCompany.Model;

namespace TeaTradeCompany.ViewModels
{
    public class LogisticsAndSupplyChainManagementViewModel : BaseViewModel
    {
        private ObservableCollection<Склад> _warehouses;
        private ObservableCollection<Поставщик> _suppliers;
        private ObservableCollection<Магазины> _stores;
        private ObservableCollection<Отгрузка> _shipments;
        private readonly ApplicationDbContext _dbContext;

        public ObservableCollection<Склад> Warehouses
        {
            get => _warehouses;
            set
            {
                _warehouses = value;
                OnPropertyChanged(nameof(Warehouses));
            }
        }

        public ObservableCollection<Поставщик> Suppliers
        {
            get => _suppliers;
            set
            {
                _suppliers = value;
                OnPropertyChanged(nameof(Suppliers));
            }
        }

        public ObservableCollection<Магазины> Stores
        {
            get => _stores;
            set
            {
                _stores = value;
                OnPropertyChanged(nameof(Stores));
            }
        }

        public ObservableCollection<Отгрузка> Shipments
        {
            get => _shipments;
            set
            {
                _shipments = value;
                OnPropertyChanged(nameof(Shipments));
            }
        }

        public LogisticsAndSupplyChainManagementViewModel()
        {
            _dbContext = new ApplicationDbContext();
            LoadData();
        }

        private void LoadData()
        {
            Warehouses = new ObservableCollection<Склад>(_dbContext.Склад);
            Suppliers = new ObservableCollection<Поставщик>(_dbContext.Поставщик);
            Stores = new ObservableCollection<Магазины>(_dbContext.Магазин);
            Shipments = new ObservableCollection<Отгрузка>(_dbContext.Отгрузка);
        }
    }
}
