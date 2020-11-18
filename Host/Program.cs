using Memorama;
using Modelo;
using Modelo.Modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Host
{
    [ServiceContract]
    public interface IClient          //IClientServiceCallback
    {
        [OperationContract(IsOneWay = true)]
        void RecibirMensaje(Mensaje mensaje);

        [OperationContract(IsOneWay = true)]
        void UsuariosConectados(ObservableCollection<Jugador> jugadores);

        [OperationContract (IsOneWay = true)]
        void VerificarUsuarioLogeado(bool logeado);
       

    }

    [ServiceContract(CallbackContract = typeof(IClient))]
    public interface IService               

    {
        [OperationContract(IsOneWay = true)]
        void Conectarse(Jugador usuario);

        [OperationContract(IsOneWay = true)]
        void EnviarMensaje(Mensaje mensaje);

        [OperationContract(IsOneWay = false)]
        ObservableCollection<Jugador> GetUsuariosConectados();

        [OperationContract(IsOneWay = true)]
        void Login(String nombre, string contrasenia);

    }
}
