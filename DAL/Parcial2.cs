using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAL
{
   public  class Parcial2:DbContext
    {
        public Parcial2():base("ConSTR")
        {

        }
        public DbSet<Presupuesto> presupuesto { get; set; }
        public DbSet<PresupuestoDetalle> relacion { get; set; }
    }
}
