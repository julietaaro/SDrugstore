using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
namespace LightSwitchApplication
{
    public partial class Compra
    {
        partial void Total_Compute(ref decimal result)
        {
            result = this.DetalleCompra.Sum(item => item.Subtotal);// Establece el resultado en el valor del campo deseado

        }
    }
}
