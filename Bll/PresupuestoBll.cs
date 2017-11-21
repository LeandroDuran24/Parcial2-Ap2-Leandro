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
    public class PresupuestoBll
    {
        public static Presupuesto Guardar(Presupuesto nuevo)
        {
            Presupuesto result = null;
            using (var conn = new Repositorio<Presupuesto>())
            {
                result = conn.Guardar(nuevo);
            }
            return result;
        }

        public static bool Modificar(Presupuesto criterio)
        {
            bool result = false;
            using (var conn = new Repositorio<Presupuesto>())
            {
                result = conn.Modificar(criterio);
            }
            return result;
        }

        public static Presupuesto Buscar(Expression<Func<Presupuesto, bool>> id)
        {
            Presupuesto result = null;
            using (var conn = new Repositorio<Presupuesto>())
            {

                result = conn.Buscar(id);


            }
            return result;
        }

        public static bool Eliminar(Presupuesto id)
        {
            bool retorno = false;
            using (var conn = new Repositorio<Presupuesto>())
            {
                retorno = conn.Eliminar(id);


            }
            return retorno;
        }

        public static List<Presupuesto> GetList(Expression<Func<Presupuesto, bool>> id)
        {
            List<Presupuesto> lista = null;
            using (var conn = new Repositorio<Presupuesto>())
            {

                lista = conn.GetList(id);


            }
            return lista;
        }

        public static List<Presupuesto> GetLisTodo()
        {
            List<Presupuesto> lista = null;
            using (var conn = new Repositorio<Presupuesto>())
            {
                
                lista= conn.GetListTodo();
              
            }
            return lista;
        }


    }

}

