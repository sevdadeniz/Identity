using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autentication.Models
{
    public class Admin
    {
        public int AdminId { get; set; }

        [Column(TypeName="varchar(20)")]
        public string Kullanici { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string Password { get; set; }


    }
}
