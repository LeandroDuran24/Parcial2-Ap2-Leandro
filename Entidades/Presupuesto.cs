using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Presupuesto
    {
        [Key]
        public int PresupuestoId { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public double Monto { get; set; }


        public virtual ICollection<PresupuestoDetalle> PresupuestoDetalleList { get; set; }

        public Presupuesto()
        {

        }

        public Presupuesto(int id,DateTime fecha,string descripcion,double monto)
        {
            this.PresupuestoId = id;
            this.Fecha = fecha;
            this.Descripcion = descripcion;
            this.Monto = monto;
        }
    }
}
