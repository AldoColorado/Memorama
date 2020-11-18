
using Modelo.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public abstract class AbstractCRUD <T>
    {
        protected MemoramaEntities db = new MemoramaEntities();
        public abstract void Crear(T entity);
        public abstract void Modificar(object entity);
        public abstract void Eliminar(object pk);
        public abstract List<T> Obtener();
        public abstract T ObtenerEntidad(Object pk);
        
    }
}
