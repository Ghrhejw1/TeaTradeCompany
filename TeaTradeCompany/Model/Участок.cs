using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaTradeCompany.Model
{
    public class Участок
    {
        [Key]
        public int ID_Участка { get; set; }
        public string Название { get; set; }
        public decimal Площадь { get; set; }
        public string Тип_растений { get; set; }
        public int FK_Плантации { get; set; }
        public Плантация Плантация { get; set; }
        public int FK_Чайного_куста { get; set; }
        public Чайный_куст ЧайныйКуст { get; set; }
    }
}
