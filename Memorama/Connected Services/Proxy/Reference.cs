﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Memorama.Proxy {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Proxy.IService", CallbackContract=typeof(Memorama.Proxy.IServiceCallback))]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IService/Conectarse")]
        void Conectarse(Modelo.Modelo.Jugador usuario);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IService/Conectarse")]
        System.Threading.Tasks.Task ConectarseAsync(Modelo.Modelo.Jugador usuario);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IService/EnviarMensaje")]
        void EnviarMensaje(Memorama.Mensaje mensaje);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IService/EnviarMensaje")]
        System.Threading.Tasks.Task EnviarMensajeAsync(Memorama.Mensaje mensaje);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetUsuariosConectados", ReplyAction="http://tempuri.org/IService/GetUsuariosConectadosResponse")]
        Modelo.Modelo.Jugador[] GetUsuariosConectados();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetUsuariosConectados", ReplyAction="http://tempuri.org/IService/GetUsuariosConectadosResponse")]
        System.Threading.Tasks.Task<Modelo.Modelo.Jugador[]> GetUsuariosConectadosAsync();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IService/Login")]
        void Login(string nombre, string contrasenia);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IService/Login")]
        System.Threading.Tasks.Task LoginAsync(string nombre, string contrasenia);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IService/CrearJugador")]
        void CrearJugador(Modelo.Modelo.Jugador jugador);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IService/CrearJugador")]
        System.Threading.Tasks.Task CrearJugadorAsync(Modelo.Modelo.Jugador jugador);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IService/RecibirMensaje")]
        void RecibirMensaje(Memorama.Mensaje mensaje);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IService/UsuariosConectados")]
        void UsuariosConectados(Modelo.Modelo.Jugador[] jugadores);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IService/VerificarUsuarioLogeado")]
        void VerificarUsuarioLogeado(bool logeado);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IService/VerificarCreacionJugador")]
        void VerificarCreacionJugador(bool creado);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : Memorama.Proxy.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.DuplexClientBase<Memorama.Proxy.IService>, Memorama.Proxy.IService {
        
        public ServiceClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public ServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public ServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void Conectarse(Modelo.Modelo.Jugador usuario) {
            base.Channel.Conectarse(usuario);
        }
        
        public System.Threading.Tasks.Task ConectarseAsync(Modelo.Modelo.Jugador usuario) {
            return base.Channel.ConectarseAsync(usuario);
        }
        
        public void EnviarMensaje(Memorama.Mensaje mensaje) {
            base.Channel.EnviarMensaje(mensaje);
        }
        
        public System.Threading.Tasks.Task EnviarMensajeAsync(Memorama.Mensaje mensaje) {
            return base.Channel.EnviarMensajeAsync(mensaje);
        }
        
        public Modelo.Modelo.Jugador[] GetUsuariosConectados() {
            return base.Channel.GetUsuariosConectados();
        }
        
        public System.Threading.Tasks.Task<Modelo.Modelo.Jugador[]> GetUsuariosConectadosAsync() {
            return base.Channel.GetUsuariosConectadosAsync();
        }
        
        public void Login(string nombre, string contrasenia) {
            base.Channel.Login(nombre, contrasenia);
        }
        
        public System.Threading.Tasks.Task LoginAsync(string nombre, string contrasenia) {
            return base.Channel.LoginAsync(nombre, contrasenia);
        }
        
        public void CrearJugador(Modelo.Modelo.Jugador jugador) {
            base.Channel.CrearJugador(jugador);
        }
        
        public System.Threading.Tasks.Task CrearJugadorAsync(Modelo.Modelo.Jugador jugador) {
            return base.Channel.CrearJugadorAsync(jugador);
        }
    }
}
