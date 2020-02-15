using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
namespace LightSwitchApplication
{
    public partial class Producto
    {

        partial void PrecioVenta_Compute(ref decimal result)
        {

            result = this.PrecioCompra * 2;// Establece el resultado en el valor del campo deseado

        } 
       
    }
}

namespace UserCode
{
    public partial class Producto
    {
    }
}
