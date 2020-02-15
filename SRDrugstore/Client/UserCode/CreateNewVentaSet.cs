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
    public partial class CreateNewVentaSet
    {
        partial void CreateNewVentaSet_InitializeDataWorkspace(global::System.Collections.Generic.List<global::Microsoft.LightSwitch.IDataService> saveChangesTo)
        {
            // Escriba el código aquí.
            this.VentaSetProperty = new VentaSet();

            
            
        }

        partial void CreateNewVentaSet_Saving(ref bool handled)
        {

            // Escriba el código aquí.
            foreach (var item in DetalleVenta)
            {
                
                
                        item.Producto.Stock -= item.Cantidad;
                        this.DataWorkspace.C__USERS_JULIETA_DOCUMENTS_VISUAL_STUDIO_2010_PROJECTS_AACD_D.SaveChanges();

                    
            }
        }

        partial void CreateNewVentaSet_Saved()
        {
            // Escriba el código aquí.
            this.Close(false);
            Application.Current.ShowDefaultScreen(this.VentaSetProperty);
        }
    }
}