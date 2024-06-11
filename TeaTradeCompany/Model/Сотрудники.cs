using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaTradeCompany.Model
{
    public class Сотрудники
    {
        [Key]
        public int ID_Сотрудника { get; set; }
        public string Имя { get; set; }
        public string Фамилия { get; set; }
        public string Должность { get; set; }
        public string Телефон { get; set; }
        public string Email { get; set; }
        public DateTime? Дата_найма { get; set; }
        public string Пароль { get; set; }
        public string Логин { get; set; }
        
        public ICollection<Департамент> Департаменты { get; set; }
    }

}
