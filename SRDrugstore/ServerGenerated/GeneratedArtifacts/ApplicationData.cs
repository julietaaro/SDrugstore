//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace ApplicationData.Implementation
{
    #region Contextos
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    public partial class ApplicationDataObjectContext : ObjectContext
    {
        #region Constructores
    
        /// <summary>
        /// Inicializa un nuevo objeto ApplicationDataObjectContext usando la cadena de conexión encontrada en la sección 'ApplicationDataObjectContext' del archivo de configuración de la aplicación.
        /// </summary>
        public ApplicationDataObjectContext() : base("name=ApplicationDataObjectContext", "ApplicationDataObjectContext")
        {
            OnContextCreated();
        }
    
        /// <summary>
        /// Inicializar un nuevo objeto ApplicationDataObjectContext.
        /// </summary>
        public ApplicationDataObjectContext(string connectionString) : base(connectionString, "ApplicationDataObjectContext")
        {
            OnContextCreated();
        }
    
        /// <summary>
        /// Inicializar un nuevo objeto ApplicationDataObjectContext.
        /// </summary>
        public ApplicationDataObjectContext(EntityConnection connection) : base(connection, "ApplicationDataObjectContext")
        {
            OnContextCreated();
        }
    
        #endregion
    
        #region Métodos parciales
    
        partial void OnContextCreated();
    
        #endregion
    
    }

    #endregion

    
}
