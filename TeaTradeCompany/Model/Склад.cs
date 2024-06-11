using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaTradeCompany.Model
{
    public class Склад
    {
        [Key]
        public int ID_Склада { get; set; }
        public string Название { get; set; }
        public string Адрес { get; set; }
        public string Телефон { get; set; }
        public string Email { get; set; }
        public int Вмещаемость { get; set; }
        public ICollection<Отгрузка> Отгрузки { get; set; }
    }

}
