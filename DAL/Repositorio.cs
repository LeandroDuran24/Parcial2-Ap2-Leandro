using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Repositorio<TEntity> : IRepository<TEntity> where TEntity : class
    {
        Parcial2 context = null;

        public Repositorio()
        {
            context = new Parcial2();
        }


        private DbSet<TEntity> EntitySet
        {
            get
            {
                return context.Set<TEntity>();
            }
        }


        public TEntity Buscar(Expression<Func<TEntity, bool>> criterioBusqueda)
        {
            try
            {
                return EntitySet.FirstOrDefault(criterioBusqueda);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public TEntity BuscarOtro(int id)
        {
            try
            {
                return EntitySet.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Dispose()
        {
            if (context != null)

                context.Dispose();

        }

        public bool Eliminar(TEntity criterioBusqueda)
        {
            try
            {
                EntitySet.Attach(criterioBusqueda);
                EntitySet.Remove(criterioBusqueda);
                return context.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> criterioBusqueda)
        {
            try
            {
                return EntitySet.Where(criterioBusqueda).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<TEntity> GetListTodo()
        {
            try
            {
                return EntitySet.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public TEntity Guardar(TEntity criterioBusqueda)
        {
            try
            {
                EntitySet.Add(criterioBusqueda);
                context.SaveChanges();
                return criterioBusqueda;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Modificar(TEntity criterioBusqueda)
        {
            try
            {
                EntitySet.Attach(criterioBusqueda);
                context.Entry(criterioBusqueda).State = EntityState.Modified;
                return context.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
