using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaTradeCompany.Model
{
    public class Поставщик
    {
        [Key]
        public int ID_Поставщика { get; set; }
        public string Название { get; set; }
        public string Контактное_лицо { get; set; }
        public string Телефон { get; set; }
        public string Email { get; set; }
        public string Адрес { get; set; }
        public ICollection<Сортировочный_центр> СортировочныеЦентры { get; set; }
    }

}
