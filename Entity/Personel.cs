using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Personel
    {
        [Key]
        public int PersonelID { get; set; }
        public string PersonelName { get; set; }
        public string PersonelPassword { get; set; }
        public DateTime PersonelDate { get; set; }
        public string PersonelSektor { get; set; }
        public string PersonelMail { get; set; }
        public string PersonelPhone { get; set; }
        public string PersonelAdress { get; set; }




    }
}
