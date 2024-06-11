using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaTradeCompany.Model
{
    public class Плантация
    {
        [Key]
        public int ID_Плантации { get; set; }
        public string Название { get; set; }
        public string Адрес { get; set; }
        public decimal Площадь { get; set; }
        public string Тип_почвы { get; set; }
        public ICollection<Участок> Участки { get; set; }
        public ICollection<Департамент> Департаменты { get; set; }
    }
}
