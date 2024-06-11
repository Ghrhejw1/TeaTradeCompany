using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaTradeCompany.Model
{
    public class Покупатель
    {
        [Key]
        public int ID_Покупателя { get; set; }
        public string Имя { get; set; }
        public string Адрес { get; set; }
        public string Телефон { get; set; }
        public string Email { get; set; }
        public DateTime? Дата_регистрации { get; set; }
        public int FK_Магазина { get; set; }
        public Магазины Магазин { get; set; }
    }
}
