using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaTradeCompany.Model
{
    public class Департамент
    {
        [Key]
        public int ID_Департамента { get; set; }
        public string Название { get; set; }
        public string Руководитель { get; set; }
        public string Телефон { get; set; }
        public string Email { get; set; }
        public int FK_Сотрудника { get; set; }
        public Сотрудники Сотрудник { get; set; }
        public int FK_Плантации { get; set; }
        public Плантация Плантация { get; set; }
        public string Отчёт { get; set; }
    }
}
