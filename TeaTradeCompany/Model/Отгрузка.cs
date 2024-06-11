using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaTradeCompany.Model
{
    public class Отгрузка
    {
        [Key]
        public int ID_Отгрузки { get; set; }
        public DateTime? Дата_отгрузки { get; set; }
        public string Адрес_получателя { get; set; }
        public string Ответственное_лицо { get; set; }
        public string Телефон { get; set; }
        public int FK_Заказа { get; set; }
        public Заказ Заказ { get; set; }
        public int FK_Склада { get; set; }
        public Склад Склад { get; set; }
    }

}
