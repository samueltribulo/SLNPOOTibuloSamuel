using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsEFDatos.Models;

namespace WindowsEFDatos.Data
{
    public class DBLineaAereaContext : DbContext
    {

        public DBLineaAereaContext():base("KeyDB") { }
        public virtual DbSet<Avion> Aviones { get; set; }

        public virtual DbSet<LineaAerea> LineasAereas { get; set; }

    }
}
