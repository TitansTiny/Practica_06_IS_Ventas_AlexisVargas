
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace AcessoADatos
{

using System;
    using System.Collections.Generic;
    
public partial class Clientes
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Clientes()
    {

        this.Factura = new List<Factura>();

    }


    public int id { get; set; }

    public string cedula { get; set; }

    public string nombre { get; set; }

    public string direccion { get; set; }

    public string telefono { get; set; }

    public int idCategoria { get; set; }



    public virtual Categoria Categoria { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual List<Factura> Factura { get; set; }

}

}
