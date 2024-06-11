using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaTradeCompany.Model
{
    public class Обработка_чая
    {
        [Key]
        public int ID_Обработки { get; set; }
        public DateTime? Дата_обработки { get; set; }
        public string Метод_обработки { get; set; }
        public string Ответственный_сотрудник { get; set; }
        public int FK_Продукта { get; set; }
        public Продукт Продукт { get; set; }
        public int FK_Процесса { get; set; }
        public Технологический_Процесс Процесс { get; set; }
    }

}
