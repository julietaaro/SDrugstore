

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LightSwitchApplication
{
    #region Entities
    
    /// <summary>
    /// No hay ninguna descripción modelada
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
    public sealed partial class Proveedor : global::Microsoft.LightSwitch.Framework.Base.EntityObject<global::LightSwitchApplication.Proveedor, global::LightSwitchApplication.Proveedor.DetailsClass>
    {
        #region Constructors
    
        /// <summary>
        /// Inicializa una nueva instancia de la entidad Proveedor.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public Proveedor()
            : this(null)
        {
        }
    
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public Proveedor(global::Microsoft.LightSwitch.Framework.EntitySet<global::LightSwitchApplication.Proveedor> entitySet)
            : base(entitySet)
        {
            global::LightSwitchApplication.Proveedor.DetailsClass.Initialize(this);
        }
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Proveedor_Created();
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Proveedor_AllowSaveWithErrors(ref bool result);
    
        #endregion
    
        #region Private Properties
        
        /// <summary>
        /// Obtiene el objeto Application para esta aplicación. El objeto Application proporciona acceso a pantallas activas, métodos para abrir pantallas y acceso al usuario actual.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::Microsoft.LightSwitch.IApplication<global::LightSwitchApplication.DataWorkspace> Application
        {
            get
            {
                return global::LightSwitchApplication.Application.Current;
            }
        }
        
        /// <summary>
        /// Obtiene el área de trabajo de datos contenedora. Dicha área proporciona acceso a todos los orígenes de datos de la aplicación.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::LightSwitchApplication.DataWorkspace DataWorkspace
        {
            get
            {
                return (global::LightSwitchApplication.DataWorkspace)this.Details.EntitySet.Details.DataService.Details.DataWorkspace;
            }
        }
        
        #endregion
    
        #region Public Properties
    
        /// <summary>
        /// No hay ninguna descripción modelada
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public long CUIT
        {
            get
            {
                return global::LightSwitchApplication.Proveedor.DetailsClass.GetValue(this, global::LightSwitchApplication.Proveedor.DetailsClass.PropertySetProperties.CUIT);
            }
            set
            {
                global::LightSwitchApplication.Proveedor.DetailsClass.SetValue(this, global::LightSwitchApplication.Proveedor.DetailsClass.PropertySetProperties.CUIT, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void CUIT_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void CUIT_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void CUIT_Changed();

        /// <summary>
        /// No hay ninguna descripción modelada
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public string RazonSocial
        {
            get
            {
                return global::LightSwitchApplication.Proveedor.DetailsClass.GetValue(this, global::LightSwitchApplication.Proveedor.DetailsClass.PropertySetProperties.RazonSocial);
            }
            set
            {
                global::LightSwitchApplication.Proveedor.DetailsClass.SetValue(this, global::LightSwitchApplication.Proveedor.DetailsClass.PropertySetProperties.RazonSocial, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void RazonSocial_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void RazonSocial_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void RazonSocial_Changed();

        /// <summary>
        /// No hay ninguna descripción modelada
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public string Direccion
        {
            get
            {
                return global::LightSwitchApplication.Proveedor.DetailsClass.GetValue(this, global::LightSwitchApplication.Proveedor.DetailsClass.PropertySetProperties.Direccion);
            }
            set
            {
                global::LightSwitchApplication.Proveedor.DetailsClass.SetValue(this, global::LightSwitchApplication.Proveedor.DetailsClass.PropertySetProperties.Direccion, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Direccion_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Direccion_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Direccion_Changed();

        /// <summary>
        /// No hay ninguna descripción modelada
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public string Telefono
        {
            get
            {
                return global::LightSwitchApplication.Proveedor.DetailsClass.GetValue(this, global::LightSwitchApplication.Proveedor.DetailsClass.PropertySetProperties.Telefono);
            }
            set
            {
                global::LightSwitchApplication.Proveedor.DetailsClass.SetValue(this, global::LightSwitchApplication.Proveedor.DetailsClass.PropertySetProperties.Telefono, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Telefono_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Telefono_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Telefono_Changed();

        /// <summary>
        /// No hay ninguna descripción modelada
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public int Id
        {
            get
            {
                return global::LightSwitchApplication.Proveedor.DetailsClass.GetValue(this, global::LightSwitchApplication.Proveedor.DetailsClass.PropertySetProperties.Id);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Id_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Id_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Id_Changed();

        /// <summary>
        /// No hay ninguna descripción modelada
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Microsoft.LightSwitch.Framework.EntityCollection<global::LightSwitchApplication.Compra> Compra
        {
            get
            {
                return global::LightSwitchApplication.Proveedor.DetailsClass.GetValue(this, global::LightSwitchApplication.Proveedor.DetailsClass.PropertySetProperties.Compra);
            }
        }
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public Microsoft.LightSwitch.IDataServiceQueryable<global::LightSwitchApplication.Compra> CompraQuery
        {
            get
            {
                return global::LightSwitchApplication.Proveedor.DetailsClass.GetQuery(this, global::LightSwitchApplication.Proveedor.DetailsClass.PropertySetProperties.Compra);
            }
        }

        #endregion
    
        #region Details Class
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public sealed class DetailsClass : global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<
                global::LightSwitchApplication.Proveedor,
                global::LightSwitchApplication.Proveedor.DetailsClass,
                global::LightSwitchApplication.Proveedor.DetailsClass.IImplementation,
                global::LightSwitchApplication.Proveedor.DetailsClass.PropertySet,
                global::Microsoft.LightSwitch.Details.Framework.EntityCommandSet<global::LightSwitchApplication.Proveedor, global::LightSwitchApplication.Proveedor.DetailsClass>,
                global::Microsoft.LightSwitch.Details.Framework.EntityMethodSet<global::LightSwitchApplication.Proveedor, global::LightSwitchApplication.Proveedor.DetailsClass>>
        {
    
            static DetailsClass()
            {
                var initializeEntry = global::LightSwitchApplication.Proveedor.DetailsClass.PropertySetProperties.CUIT;
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static readonly global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<global::LightSwitchApplication.Proveedor, global::LightSwitchApplication.Proveedor.DetailsClass>.Entry
                __ProveedorEntry = new global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<global::LightSwitchApplication.Proveedor, global::LightSwitchApplication.Proveedor.DetailsClass>.Entry(
                    global::LightSwitchApplication.Proveedor.DetailsClass.__Proveedor_CreateNew,
                    global::LightSwitchApplication.Proveedor.DetailsClass.__Proveedor_Created,
                    global::LightSwitchApplication.Proveedor.DetailsClass.__Proveedor_AllowSaveWithErrors);
            private static global::LightSwitchApplication.Proveedor __Proveedor_CreateNew(global::Microsoft.LightSwitch.Framework.EntitySet<global::LightSwitchApplication.Proveedor> es)
            {
                return new global::LightSwitchApplication.Proveedor(es);
            }
            private static void __Proveedor_Created(global::LightSwitchApplication.Proveedor e)
            {
                e.Proveedor_Created();
            }
            private static bool __Proveedor_AllowSaveWithErrors(global::LightSwitchApplication.Proveedor e)
            {
                bool result = false;
                e.Proveedor_AllowSaveWithErrors(ref result);
                return result;
            }
    
            public DetailsClass() : base()
            {
            }
    
            public new global::Microsoft.LightSwitch.Details.Framework.EntityCommandSet<global::LightSwitchApplication.Proveedor, global::LightSwitchApplication.Proveedor.DetailsClass> Commands
            {
                get
                {
                    return base.Commands;
                }
            }
    
            public new global::Microsoft.LightSwitch.Details.Framework.EntityMethodSet<global::LightSwitchApplication.Proveedor, global::LightSwitchApplication.Proveedor.DetailsClass> Methods
            {
                get
                {
                    return base.Methods;
                }
            }
    
            public new global::LightSwitchApplication.Proveedor.DetailsClass.PropertySet Properties
            {
                get
                {
                    return base.Properties;
                }
            }
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public sealed class PropertySet : global::Microsoft.LightSwitch.Details.Framework.Base.EntityPropertySet<global::LightSwitchApplication.Proveedor, global::LightSwitchApplication.Proveedor.DetailsClass>
            {
    
                public PropertySet() : base()
                {
                }
    
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Proveedor, global::LightSwitchApplication.Proveedor.DetailsClass, long> CUIT
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Proveedor.DetailsClass.PropertySetProperties.CUIT) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Proveedor, global::LightSwitchApplication.Proveedor.DetailsClass, long>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Proveedor, global::LightSwitchApplication.Proveedor.DetailsClass, string> RazonSocial
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Proveedor.DetailsClass.PropertySetProperties.RazonSocial) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Proveedor, global::LightSwitchApplication.Proveedor.DetailsClass, string>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Proveedor, global::LightSwitchApplication.Proveedor.DetailsClass, string> Direccion
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Proveedor.DetailsClass.PropertySetProperties.Direccion) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Proveedor, global::LightSwitchApplication.Proveedor.DetailsClass, string>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Proveedor, global::LightSwitchApplication.Proveedor.DetailsClass, string> Telefono
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Proveedor.DetailsClass.PropertySetProperties.Telefono) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Proveedor, global::LightSwitchApplication.Proveedor.DetailsClass, string>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Proveedor, global::LightSwitchApplication.Proveedor.DetailsClass, int> Id
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Proveedor.DetailsClass.PropertySetProperties.Id) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Proveedor, global::LightSwitchApplication.Proveedor.DetailsClass, int>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Proveedor, global::LightSwitchApplication.Proveedor.DetailsClass, global::LightSwitchApplication.Compra> Compra
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Proveedor.DetailsClass.PropertySetProperties.Compra) as global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Proveedor, global::LightSwitchApplication.Proveedor.DetailsClass, global::LightSwitchApplication.Compra>;
                    }
                }
                
            }
    
            #pragma warning disable 109
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
            public interface IImplementation : global::Microsoft.LightSwitch.Internal.IEntityImplementation
            {
                new long CUIT { get; set; }
                new string RazonSocial { get; set; }
                new string Direccion { get; set; }
                new string Telefono { get; set; }
                new int Id { get; }
                new global::System.Collections.IEnumerable Compra { get; }
            }
            #pragma warning restore 109
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal class PropertySetProperties
            {
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Proveedor, global::LightSwitchApplication.Proveedor.DetailsClass, long>.Entry
                    CUIT = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Proveedor, global::LightSwitchApplication.Proveedor.DetailsClass, long>.Entry(
                        "CUIT",
                        global::LightSwitchApplication.Proveedor.DetailsClass.PropertySetProperties._CUIT_Stub,
                        global::LightSwitchApplication.Proveedor.DetailsClass.PropertySetProperties._CUIT_ComputeIsReadOnly,
                        global::LightSwitchApplication.Proveedor.DetailsClass.PropertySetProperties._CUIT_Validate,
                        global::LightSwitchApplication.Proveedor.DetailsClass.PropertySetProperties._CUIT_GetImplementationValue,
                        global::LightSwitchApplication.Proveedor.DetailsClass.PropertySetProperties._CUIT_SetImplementationValue,
                        global::LightSwitchApplication.Proveedor.DetailsClass.PropertySetProperties._CUIT_OnValueChanged);
                private static void _CUIT_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Proveedor.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Proveedor, global::LightSwitchApplication.Proveedor.DetailsClass, long>.Data> c, global::LightSwitchApplication.Proveedor.DetailsClass d, object sf)
                {
                    c(d, ref d._CUIT, sf);
                }
                private static bool _CUIT_ComputeIsReadOnly(global::LightSwitchApplication.Proveedor e)
                {
                    bool result = false;
                    e.CUIT_IsReadOnly(ref result);
                    return result;
                }
                private static void _CUIT_Validate(global::LightSwitchApplication.Proveedor e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.CUIT_Validate(r);
                }
                private static long _CUIT_GetImplementationValue(global::LightSwitchApplication.Proveedor.DetailsClass d)
                {
                    return d.ImplementationEntity.CUIT;
                }
                private static void _CUIT_SetImplementationValue(global::LightSwitchApplication.Proveedor.DetailsClass d, long v)
                {
                    d.ImplementationEntity.CUIT = v;
                }
                private static void _CUIT_OnValueChanged(global::LightSwitchApplication.Proveedor e)
                {
                    e.CUIT_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Proveedor, global::LightSwitchApplication.Proveedor.DetailsClass, string>.Entry
                    RazonSocial = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Proveedor, global::LightSwitchApplication.Proveedor.DetailsClass, string>.Entry(
                        "RazonSocial",
                        global::LightSwitchApplication.Proveedor.DetailsClass.PropertySetProperties._RazonSocial_Stub,
                        global::LightSwitchApplication.Proveedor.DetailsClass.PropertySetProperties._RazonSocial_ComputeIsReadOnly,
                        global::LightSwitchApplication.Proveedor.DetailsClass.PropertySetProperties._RazonSocial_Validate,
                        global::LightSwitchApplication.Proveedor.DetailsClass.PropertySetProperties._RazonSocial_GetImplementationValue,
                        global::LightSwitchApplication.Proveedor.DetailsClass.PropertySetProperties._RazonSocial_SetImplementationValue,
                        global::LightSwitchApplication.Proveedor.DetailsClass.PropertySetProperties._RazonSocial_OnValueChanged);
                private static void _RazonSocial_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Proveedor.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Proveedor, global::LightSwitchApplication.Proveedor.DetailsClass, string>.Data> c, global::LightSwitchApplication.Proveedor.DetailsClass d, object sf)
                {
                    c(d, ref d._RazonSocial, sf);
                }
                private static bool _RazonSocial_ComputeIsReadOnly(global::LightSwitchApplication.Proveedor e)
                {
                    bool result = false;
                    e.RazonSocial_IsReadOnly(ref result);
                    return result;
                }
                private static void _RazonSocial_Validate(global::LightSwitchApplication.Proveedor e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.RazonSocial_Validate(r);
                }
                private static string _RazonSocial_GetImplementationValue(global::LightSwitchApplication.Proveedor.DetailsClass d)
                {
                    return d.ImplementationEntity.RazonSocial;
                }
                private static void _RazonSocial_SetImplementationValue(global::LightSwitchApplication.Proveedor.DetailsClass d, string v)
                {
                    d.ImplementationEntity.RazonSocial = v;
                }
                private static void _RazonSocial_OnValueChanged(global::LightSwitchApplication.Proveedor e)
                {
                    e.RazonSocial_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Proveedor, global::LightSwitchApplication.Proveedor.DetailsClass, string>.Entry
                    Direccion = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Proveedor, global::LightSwitchApplication.Proveedor.DetailsClass, string>.Entry(
                        "Direccion",
                        global::LightSwitchApplication.Proveedor.DetailsClass.PropertySetProperties._Direccion_Stub,
                        global::LightSwitchApplication.Proveedor.DetailsClass.PropertySetProperties._Direccion_ComputeIsReadOnly,
                        global::LightSwitchApplication.Proveedor.DetailsClass.PropertySetProperties._Direccion_Validate,
                        global::LightSwitchApplication.Proveedor.DetailsClass.PropertySetProperties._Direccion_GetImplementationValue,
                        global::LightSwitchApplication.Proveedor.DetailsClass.PropertySetProperties._Direccion_SetImplementationValue,
                        global::LightSwitchApplication.Proveedor.DetailsClass.PropertySetProperties._Direccion_OnValueChanged);
                private static void _Direccion_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Proveedor.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Proveedor, global::LightSwitchApplication.Proveedor.DetailsClass, string>.Data> c, global::LightSwitchApplication.Proveedor.DetailsClass d, object sf)
                {
                    c(d, ref d._Direccion, sf);
                }
                private static bool _Direccion_ComputeIsReadOnly(global::LightSwitchApplication.Proveedor e)
                {
                    bool result = false;
                    e.Direccion_IsReadOnly(ref result);
                    return result;
                }
                private static void _Direccion_Validate(global::LightSwitchApplication.Proveedor e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.Direccion_Validate(r);
                }
                private static string _Direccion_GetImplementationValue(global::LightSwitchApplication.Proveedor.DetailsClass d)
                {
                    return d.ImplementationEntity.Direccion;
                }
                private static void _Direccion_SetImplementationValue(global::LightSwitchApplication.Proveedor.DetailsClass d, string v)
                {
                    d.ImplementationEntity.Direccion = v;
                }
                private static void _Direccion_OnValueChanged(global::LightSwitchApplication.Proveedor e)
                {
                    e.Direccion_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Proveedor, global::LightSwitchApplication.Proveedor.DetailsClass, string>.Entry
                    Telefono = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Proveedor, global::LightSwitchApplication.Proveedor.DetailsClass, string>.Entry(
                        "Telefono",
                        global::LightSwitchApplication.Proveedor.DetailsClass.PropertySetProperties._Telefono_Stub,
                        global::LightSwitchApplication.Proveedor.DetailsClass.PropertySetProperties._Telefono_ComputeIsReadOnly,
                        global::LightSwitchApplication.Proveedor.DetailsClass.PropertySetProperties._Telefono_Validate,
                        global::LightSwitchApplication.Proveedor.DetailsClass.PropertySetProperties._Telefono_GetImplementationValue,
                        global::LightSwitchApplication.Proveedor.DetailsClass.PropertySetProperties._Telefono_SetImplementationValue,
                        global::LightSwitchApplication.Proveedor.DetailsClass.PropertySetProperties._Telefono_OnValueChanged);
                private static void _Telefono_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Proveedor.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Proveedor, global::LightSwitchApplication.Proveedor.DetailsClass, string>.Data> c, global::LightSwitchApplication.Proveedor.DetailsClass d, object sf)
                {
                    c(d, ref d._Telefono, sf);
                }
                private static bool _Telefono_ComputeIsReadOnly(global::LightSwitchApplication.Proveedor e)
                {
                    bool result = false;
                    e.Telefono_IsReadOnly(ref result);
                    return result;
                }
                private static void _Telefono_Validate(global::LightSwitchApplication.Proveedor e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.Telefono_Validate(r);
                }
                private static string _Telefono_GetImplementationValue(global::LightSwitchApplication.Proveedor.DetailsClass d)
                {
                    return d.ImplementationEntity.Telefono;
                }
                private static void _Telefono_SetImplementationValue(global::LightSwitchApplication.Proveedor.DetailsClass d, string v)
                {
                    d.ImplementationEntity.Telefono = v;
                }
                private static void _Telefono_OnValueChanged(global::LightSwitchApplication.Proveedor e)
                {
                    e.Telefono_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Proveedor, global::LightSwitchApplication.Proveedor.DetailsClass, int>.Entry
                    Id = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Proveedor, global::LightSwitchApplication.Proveedor.DetailsClass, int>.Entry(
                        "Id",
                        global::LightSwitchApplication.Proveedor.DetailsClass.PropertySetProperties._Id_Stub,
                        global::LightSwitchApplication.Proveedor.DetailsClass.PropertySetProperties._Id_ComputeIsReadOnly,
                        global::LightSwitchApplication.Proveedor.DetailsClass.PropertySetProperties._Id_Validate,
                        global::LightSwitchApplication.Proveedor.DetailsClass.PropertySetProperties._Id_GetImplementationValue,
                        null,
                        global::LightSwitchApplication.Proveedor.DetailsClass.PropertySetProperties._Id_OnValueChanged);
                private static void _Id_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Proveedor.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Proveedor, global::LightSwitchApplication.Proveedor.DetailsClass, int>.Data> c, global::LightSwitchApplication.Proveedor.DetailsClass d, object sf)
                {
                    c(d, ref d._Id, sf);
                }
                private static bool _Id_ComputeIsReadOnly(global::LightSwitchApplication.Proveedor e)
                {
                    bool result = false;
                    e.Id_IsReadOnly(ref result);
                    return result;
                }
                private static void _Id_Validate(global::LightSwitchApplication.Proveedor e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.Id_Validate(r);
                }
                private static int _Id_GetImplementationValue(global::LightSwitchApplication.Proveedor.DetailsClass d)
                {
                    return d.ImplementationEntity.Id;
                }
                private static void _Id_OnValueChanged(global::LightSwitchApplication.Proveedor e)
                {
                    e.Id_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Proveedor, global::LightSwitchApplication.Proveedor.DetailsClass, global::LightSwitchApplication.Compra>.Entry
                    Compra = new global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Proveedor, global::LightSwitchApplication.Proveedor.DetailsClass, global::LightSwitchApplication.Compra>.Entry(
                        "Compra",
                        global::LightSwitchApplication.Proveedor.DetailsClass.PropertySetProperties._Compra_Stub,
                        global::LightSwitchApplication.Proveedor.DetailsClass.PropertySetProperties._Compra_GetReferencedEntities,
                        global::LightSwitchApplication.Proveedor.DetailsClass.PropertySetProperties._Compra_GetEntityCollection);
                private static void _Compra_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Proveedor.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Proveedor, global::LightSwitchApplication.Proveedor.DetailsClass, global::LightSwitchApplication.Compra>.Data> c, global::LightSwitchApplication.Proveedor.DetailsClass d, object sf)
                {
                    c(d, ref d._Compra, sf);
                }
                private static global::System.Collections.Generic.IEnumerable<global::LightSwitchApplication.Compra> _Compra_GetReferencedEntities(global::LightSwitchApplication.Proveedor.DetailsClass d)
                {
                    return d.GetReferencedEntities<global::LightSwitchApplication.Compra, global::LightSwitchApplication.Compra.DetailsClass>(global::LightSwitchApplication.Proveedor.DetailsClass.PropertySetProperties.Compra, ref d._Compra);
                }
                private static global::System.Collections.IEnumerable _Compra_GetEntityCollection(global::LightSwitchApplication.Proveedor.DetailsClass d)
                {
                    return d.ImplementationEntity.Compra;
                }
    
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Proveedor, global::LightSwitchApplication.Proveedor.DetailsClass, long>.Data _CUIT;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Proveedor, global::LightSwitchApplication.Proveedor.DetailsClass, string>.Data _RazonSocial;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Proveedor, global::LightSwitchApplication.Proveedor.DetailsClass, string>.Data _Direccion;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Proveedor, global::LightSwitchApplication.Proveedor.DetailsClass, string>.Data _Telefono;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Proveedor, global::LightSwitchApplication.Proveedor.DetailsClass, int>.Data _Id;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Proveedor, global::LightSwitchApplication.Proveedor.DetailsClass, global::LightSwitchApplication.Compra>.Data _Compra;
            
        }
    
        #endregion
    }
    
    #endregion
}