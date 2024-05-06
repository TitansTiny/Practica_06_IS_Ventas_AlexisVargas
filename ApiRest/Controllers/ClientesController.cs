using AcessoADatos;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace ApiRest.Controllers
{
    public class ClientesController : ApiController
    {
        ClientesNegocio clienteNegocio = new ClientesNegocio();

        //Get
        public IHttpActionResult Get()
        {
            var respuesta = clienteNegocio.All();
            return Ok(respuesta);
        }
        //Get/Id
        public IHttpActionResult Get(int id)
        {
            Clientes cliente = clienteNegocio.ById(id);
            if (cliente != null)
            {
                return Ok(cliente);
            }
            return NotFound();
        }
        //Post
        public IHttpActionResult Post(Clientes cliente)
        {
            try
            {
                clienteNegocio.insertarCliente(cliente);
                return Ok("Insertado Correctamente");
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        //Put
        public IHttpActionResult Put(int id, Clientes cliente)
        {
            // Obtener el producto existente por su ID
            Clientes clienteExistente = clienteNegocio.ById(id);
            if (clienteExistente == null)
            {
                return BadRequest("El cliente no existe.");
            }

            // Actualizar los valores del producto existente con los valores del producto recibido
            clienteExistente.cedula = cliente.cedula;
            clienteExistente.nombre = cliente.nombre;
            clienteExistente.direccion = cliente.direccion;
            clienteExistente.telefono = cliente.telefono;
            clienteExistente.idCategoria = cliente.idCategoria;

            // Guardar los cambios en la base de datos
            if (clienteNegocio.actualizarCliente(clienteExistente))
            {
                return Ok("Cliente actualizado correctamente.");
            }
            else
            {
                return BadRequest();
            }
        }
        public IHttpActionResult Delete(int id)
        {
            try
            {
                Clientes clienteEliminar = clienteNegocio.ById(id);
                if (clienteEliminar == null)
                {
                    return NotFound();
                }
                clienteNegocio.eliminarCliente(clienteEliminar);
                return Ok("Cliente Eliminado Correctamente");
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}