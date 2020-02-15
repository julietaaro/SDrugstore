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
    public partial class NuevaVenta
    {
        partial void CreateNewVentaSetItemProperty_InitializeDataWorkspace(global::System.Collections.Generic.List<global::Microsoft.LightSwitch.IDataService> saveChangesTo)
        {
            // Escriba el código aquí.
            this.VentaSetItemPropertyProperty = new VentaSetItem();
        }

        partial void CreateNewVentaSetItemProperty_Saved()
        {
            // Escriba el código aquí.
            this.Close(false);
            Application.Current.ShowDefaultScreen(this.VentaSetItemPropertyProperty);
        }
    }

    public partial class CreateNewVentaSetItemProperty
    {
    }
}