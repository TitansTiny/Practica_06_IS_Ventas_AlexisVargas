
//------------------------------------------------------------------------------
// <auto-generated>
//     Este c�digo se gener� a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicaci�n.
//     Los cambios manuales en este archivo se sobrescribir�n si se regenera el c�digo.
// </auto-generated>
//------------------------------------------------------------------------------


namespace AcessoADatos
{

using System;
    using System.Collections.Generic;
    
public partial class Producto
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Producto()
    {

        this.DetalleFactura = new List<DetalleFactura>();

    }


    public int id { get; set; }

    public string nombre { get; set; }

    public decimal precio_unitario { get; set; }

    public bool iva { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual List<DetalleFactura> DetalleFactura { get; set; }

}

}
