using AcessoADatos;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Mvc;

namespace ApiRest.Controllers
{
    // NOMBRE APELLIDOS: Byron Alexis Vargas Sánchez 
    // PARALELO: 3228
    // SI – INTEGRACIÓN DE SISTEMAS 
    // FECHA: 06/05/2024
    // PRÁCTICA No. #6

    [EnableCors(origins: "http://localhost:49925", headers:"*",methods:"*")]
    public class ProductosController : ApiController
    {
        ProductosNegocio productoNegocio = new ProductosNegocio();

        //Get
        public IHttpActionResult Get()
        {
            var respuesta = productoNegocio.All();
            return Ok(respuesta);
        }
        //Get/Id
        public IHttpActionResult Get(int id)
        {
            Producto producto = productoNegocio.ById(id);
            if (producto != null)
            {
                return Ok(producto);
            }
            return NotFound();
        }
        //Post
        public IHttpActionResult Post(Producto producto)
        {
            try
            {
                productoNegocio.insertarProducto(producto);
                return Ok("Insertado Correctamente");
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        //Put
        public IHttpActionResult Put(int id, Producto producto)
        {
            // Obtener el producto existente por su ID
            Producto productoExistente = productoNegocio.ById(id);
            if (productoExistente == null)
            {
                return BadRequest("El producto no existe.");
            }

            // Actualizar los valores del producto existente con los valores del producto recibido
            productoExistente.nombre = producto.nombre;
            productoExistente.precio_unitario = producto.precio_unitario;
            productoExistente.iva = producto.iva;

            // Guardar los cambios en la base de datos
            if (productoNegocio.actualizarProducto(productoExistente))
            {
                return Ok("Producto actualizado correctamente.");
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
                Producto productoEliminar = productoNegocio.ById(id);
                if (productoEliminar == null)
                {
                    return NotFound();
                }
                productoNegocio.eliminarProducto(productoEliminar);
                return Ok("Producto Eliminado Correctamente");
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}