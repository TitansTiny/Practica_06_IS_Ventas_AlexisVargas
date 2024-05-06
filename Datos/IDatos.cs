using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public interface IDatos<T>
    {
        List<T> Listar();
        bool Actualizar(T item);
        bool Nuevo(T item);
        bool Eliminar(T item);
    }
}
