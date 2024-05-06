using AcessoADatos;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ProductoDatos : IDatos<Producto>
    {
        servicios1Entities contexto;
        public ProductoDatos()
        {
            contexto = new servicios1Entities();
        }

        public bool Nuevo(Producto producto)
        {
            if (contexto.Producto.Add(producto) != null)
            {
                contexto.SaveChanges();
                return true;
            }
            return false;
        }
        public ObjectResult listarClientesCategoria()
        {
            return contexto.SP_Clientes();
        }

        public List<Producto> Listar()
        {
            return contexto.Producto.ToList();
        }

        public Producto BuscarId(int id)
        {
            return contexto.Producto.Where(p => p.id == id).FirstOrDefault();
        }
        public bool Actualizar(Producto item)
        {
            Producto temp = BuscarId(item.id);
            //temp.idProducto = item.idProducto;
            temp.nombre = item.nombre;
            temp.precio_unitario = item.precio_unitario;
            temp.iva = item.iva;
            contexto.SaveChanges();
            return true;
        }

        public bool Eliminar(Producto item)
        {
            Producto temp = BuscarId(item.id);
            if (temp != null)
            {
                contexto.Producto.Remove(temp);
                contexto.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
