using AcessoADatos;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ClienteDatos : IDatos<Clientes>
    {
        servicios1Entities contexto;
        public ClienteDatos()
        {
            contexto = new servicios1Entities();
        }
        public bool Nuevo(Clientes item)
        {
            if (contexto.Clientes.Add(item) != null)
            {
                contexto.SaveChanges();
                return true;
            }
            return false;
        }
        public List<Clientes> Listar()
        {
            return contexto.Clientes.ToList();
        }
        public Clientes BuscarId(int id)
        {
            return contexto.Clientes.Where(c => c.id == id).FirstOrDefault();
        }
        public bool Actualizar(Clientes item)
        {
            Clientes temp = BuscarId(item.id);
            temp.cedula = item.cedula;
            temp.nombre = item.nombre;
            temp.direccion = item.direccion;
            temp.telefono = item.telefono;
            temp.idCategoria = item.idCategoria;
            contexto.SaveChanges();
            return true;
        }

        public bool Eliminar(Clientes item)
        {
            Clientes temp = BuscarId(item.id);
            if (temp != null)
            {
                contexto.Clientes.Remove(temp);
                contexto.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
