using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaTradeCompany.Model
{
    public class Используемое_оборудование
    {
        [Key]
        public int ID_Оборудования { get; set; }
        public string Название { get; set; }
        public string Тип { get; set; }
        public DateTime? Дата_покупки { get; set; }
        public decimal Стоимость { get; set; }
        public ICollection<Технологический_Процесс> ТехнологическиеПроцессы { get; set; }
    }

}
