using AcessoADatos;
using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ClientesNegocio
    {
        ClienteDatos clientes;
        public ClientesNegocio()
        {
            clientes = new ClienteDatos();
        }
        public List<Clientes> All()
        {
            return clientes.Listar();
        }
        public Clientes ById(int id)
        {
            return clientes.Listar().Where(c => c.id == id).SingleOrDefault();
        }
        public bool insertarCliente(Clientes clienteNuevo)
        {
            return clientes.Nuevo(clienteNuevo);
        }
        public bool actualizarCliente(Clientes cliente)
        {
            return clientes.Actualizar(cliente);
        }
        public bool eliminarCliente(Clientes cliente)
        {
            return clientes.Eliminar(cliente);
        }
    }
}
