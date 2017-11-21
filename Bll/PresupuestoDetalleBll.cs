using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class PresupuestoDetalleBll
    {
        public static PresupuestoDetalle Guardar(PresupuestoDetalle nuevo)
        {
            PresupuestoDetalle result = null;
            using (var conn = new Repositorio<PresupuestoDetalle>())
            {
                result = conn.Guardar(nuevo);
            }
            return result;
        }

        public static PresupuestoDetalle Buscar(Expression<Func<PresupuestoDetalle, bool>> id)
        {
            PresupuestoDetalle result = null;
            using (var conn = new Repositorio<PresupuestoDetalle>())
            {

                result = conn.Buscar(id);


            }
            return result;
        }

        public static bool Eliminar(PresupuestoDetalle id)
        {
            bool retorno = false;
            using (var conn = new Repositorio<PresupuestoDetalle>())
            {
                retorno = conn.Eliminar(id);


            }
            return retorno;
        }

        public static List<PresupuestoDetalle> GetList(Expression<Func<PresupuestoDetalle, bool>> id)
        {
            List<PresupuestoDetalle> lista = null;
            using (var conn = new Repositorio<PresupuestoDetalle>())
            {

                lista = conn.GetList(id);


            }
            return lista;
        }

        public static List<PresupuestoDetalle> GetLisTodo()
        {
            List<PresupuestoDetalle> lista = null;
            using (var conn = new Repositorio<PresupuestoDetalle>())
            {

                lista = conn.GetListTodo();

            }
            return lista;
        }


    }
}

