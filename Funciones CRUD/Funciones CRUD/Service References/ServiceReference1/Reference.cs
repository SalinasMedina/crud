﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Funciones_CRUD.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.Ifunciones")]
    public interface Ifunciones {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Ifunciones/guardar", ReplyAction="http://tempuri.org/Ifunciones/guardarResponse")]
        void guardar(int a, string b, int c, float d, string e);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Ifunciones/leer", ReplyAction="http://tempuri.org/Ifunciones/leerResponse")]
        string[] leer();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Ifunciones/modificar", ReplyAction="http://tempuri.org/Ifunciones/modificarResponse")]
        bool modificar(int a, string b, int c, float d, string e);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Ifunciones/eliminar", ReplyAction="http://tempuri.org/Ifunciones/eliminarResponse")]
        bool eliminar(int a);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Ifunciones/buscar", ReplyAction="http://tempuri.org/Ifunciones/buscarResponse")]
        string[] buscar(int cla);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IfuncionesChannel : Funciones_CRUD.ServiceReference1.Ifunciones, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class IfuncionesClient : System.ServiceModel.ClientBase<Funciones_CRUD.ServiceReference1.Ifunciones>, Funciones_CRUD.ServiceReference1.Ifunciones {
        
        public IfuncionesClient() {
        }
        
        public IfuncionesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public IfuncionesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IfuncionesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IfuncionesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void guardar(int a, string b, int c, float d, string e) {
            base.Channel.guardar(a, b, c, d, e);
        }
        
        public string[] leer() {
            return base.Channel.leer();
        }
        
        public bool modificar(int a, string b, int c, float d, string e) {
            return base.Channel.modificar(a, b, c, d, e);
        }
        
        public bool eliminar(int a) {
            return base.Channel.eliminar(a);
        }
        
        public string[] buscar(int cla) {
            return base.Channel.buscar(cla);
        }
    }
}