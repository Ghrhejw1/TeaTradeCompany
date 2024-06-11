using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaTradeCompany.Model
{
    public class Чайный_куст
    {
        [Key]
        public int ID_Чайного_куста { get; set; }
        public string Вид { get; set; }
        public int Возраст { get; set; }
        public decimal Площадь_посадки { get; set; }
        public int FK_Обработка_чая { get; set; }
        public Обработка_чая ОбработкаЧая { get; set; }
        public ICollection<Параметры_климата> ПараметрыКлимата { get; set; }
        public ICollection<Участок> Участки { get; set; }
    }
}
