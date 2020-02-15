using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
namespace LightSwitchApplication
{
    public partial class DetalleCompra
    {

        partial void Subtotal_Compute(ref decimal result)
        {
            if (this.Cantidad > 0)
            {
                result = this.PrecioUnitario.Value * this.Cantidad;
            }// Establece el resultado en el valor del campo deseado

        }
    }
}
