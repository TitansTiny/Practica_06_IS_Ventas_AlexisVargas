using AcessoADatos;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class CategoriaDatos : IDatos<Categoria>
    {
        servicios1Entities contexto;
        public CategoriaDatos()
        {
            contexto = new servicios1Entities();
        }
        public bool Nuevo(Categoria item)
        {
            if (contexto.Categoria.Add(item) != null)
            {
                contexto.SaveChanges();
                return true;
            }
            return false;
        }
        public List<Categoria> Listar()
        {
            return contexto.Categoria.ToList();
        }
        public Categoria BuscarId(int id)
        {
            return contexto.Categoria.Where(c => c.id == id).FirstOrDefault();
        }
        public bool Actualizar(Categoria item)
        {
            Categoria temp = BuscarId(item.id);
            temp.nombre = item.nombre;
            contexto.SaveChanges();
            return true;
        }

        public bool Eliminar(Categoria item)
        {
            Categoria temp = BuscarId(item.id);
            if (temp != null)
            {
                contexto.Categoria.Remove(temp);
                contexto.SaveChanges();
                return true;
            }
            return false;
        }
        public ObjectResult<SP_ClientesCategorias_Result> SP_ClientesCategorias()
        {
            return contexto.SP_ClientesCategorias();
        }
    }
}
