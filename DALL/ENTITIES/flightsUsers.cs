using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALL.ENTITIES
{
    public partial class flightsUsers
    {
        [Key]
        public int idFlightUser { get; set; }
        public int idFlight { get; set; }
        public int documentNumber { get; set; }
        public virtual flights flights { get; set; }
        public virtual users users { get; set; }

    }
}
