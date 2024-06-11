using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaTradeCompany.Model
{
    public class Заказ
    {
        [Key]
        public int ID_Заказа { get; set; }
        public DateTime? Дата_заказа { get; set; }
        public decimal Сумма { get; set; }
        public string Способ_доставки { get; set; }
        public int FK_Продукта { get; set; }
        public Продукт Продукт { get; set; }
        public ICollection<Отгрузка> Отгрузки { get; set; }
    }

}
