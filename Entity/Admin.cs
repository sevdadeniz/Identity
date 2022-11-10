using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Admin
    {
        public int AdminId { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string Kullanici { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string Password { get; set; }
        
        [Column(TypeName = "varchar(20)")]
        public string Departman { get; set; }


    }
}
