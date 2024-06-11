using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaTradeCompany.Model
{
    public class Сортировочный_центр
    {
        [Key]
        public int ID_Сортировочного_центра { get; set; }
        public string Название { get; set; }
        public string Адрес { get; set; }
        public string Телефон { get; set; }
        public string Email { get; set; }
        public int FK_Поставщика { get; set; }
        public Поставщик Поставщик { get; set; }
    }

}
