using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaTradeCompany.Model
{
    public class Параметры_климата
    {
        [Key]
        public int ID_Параметров_климата { get; set; }
        public decimal Температура { get; set; }
        public decimal Влажность { get; set; }
        public decimal Осадки { get; set; }
        public DateTime? Дата_измерения { get; set; }
        public int FK_Чайного_куста_климат { get; set; }
        public Чайный_куст ЧайныйКуст { get; set; }
    }

}
