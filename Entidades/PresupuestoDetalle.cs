using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public  class PresupuestoDetalle
    {

        [Key]
        public int Id { get; set; }
        public int PresupuestoId { get; set; }
        public string Descripcion { get; set; }
        public double Meta { get; set; }
        public double Logrado { get; set; }

        public PresupuestoDetalle()
        {

        }

        public PresupuestoDetalle(string Descripcion, double Meta, double Logrado)
        {
            this.Descripcion = Descripcion;
            this.Meta = Meta;
            this.Logrado = Logrado;
        }
    }
}
