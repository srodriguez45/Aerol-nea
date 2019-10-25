using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALL.ENTITIES
{
    [Table("users")]
    public partial class users
    {
        [Index]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idUser { get; set; }
        public string userName { get; set; }
        public string documentType { get; set; }
        [Key]
        public int documentNumber { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }


    }
}
