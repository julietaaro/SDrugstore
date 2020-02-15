using System;
using System.Linq;
using System.IO;
using System.IO.IsolatedStorage;
using System.Collections.Generic;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Framework.Client;
using Microsoft.LightSwitch.Presentation;
using Microsoft.LightSwitch.Presentation.Extensions;

namespace LightSwitchApplication
{
    public partial class CreateNewCompra
    {
        partial void CreateNewCompra_InitializeDataWorkspace(global::System.Collections.Generic.List<global::Microsoft.LightSwitch.IDataService> saveChangesTo)
        {
            // Escriba el código aquí.
            this.CompraProperty = new Compra();
        }

        partial void CreateNewCompra_Saved()
        {
            // Escriba el código aquí.
            this.Close(false);
            Application.Current.ShowDefaultScreen(this.CompraProperty);
        }

        partial void CreateNewCompra_Saving(ref bool handled)
        {
            foreach (var item in DetalleCompra)
            {
                item.Producto.Stock += item.Cantidad;
            }
            // Escriba el código aquí.

        }
    }
}