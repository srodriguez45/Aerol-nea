using DALL.ENTITIES;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALL
{
    public partial class AerolineaContext : DbContext
    {
        public AerolineaContext() : base("name=AerolineaContext")
        {

        }

        public DbSet<users> users { get; set; }
        public DbSet<flights> flights { get; set; }
        public DbSet<flightsUsers> flightsUsers { get; set; }


    }

}
