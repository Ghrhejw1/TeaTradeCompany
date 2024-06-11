using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaTradeCompany.Model
{
    public class Продукт
    {
        [Key]
        public int ID_Продукта { get; set; }
        public string Название { get; set; }
        public string Описание { get; set; }
        public decimal Цена { get; set; }
        public int В_наличии { get; set; }
        public ICollection<Заказ> Заказы { get; set; }
        public ICollection<Обработка_чая> Обработки { get; set; }
    }

}
