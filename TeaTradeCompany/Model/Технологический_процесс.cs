using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaTradeCompany.Model
{
    public class Технологический_Процесс
    {
        [Key]
        public int ID_Процесса { get; set; }
        public string Название { get; set; }
        public string Описание { get; set; }
        public int FK_Процесса_Оборудования { get; set; }
        public Используемое_оборудование Оборудование { get; set; }
        public ICollection<Обработка_чая> ОбработкиЧая { get; set; }
    }

}
