using Memorama;
using Modelo;
using Modelo.Modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Host
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Single, InstanceContextMode = InstanceContextMode.Single)]
    //[ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Reentrant)]
    public partial class Memorama : IService
    {
        Dictionary<IClient, string> usuarios = new Dictionary<IClient, string>();

        private IClient callBack = null;
        private ObservableCollection<Jugador> _jugadores;
        private readonly Dictionary<string, IClient> clientes;

        public Memorama()
        {
            _jugadores = new ObservableCollection<Jugador>();
            clientes = new Dictionary<string, IClient>();
                
        }


        Dictionary<IClient, string> usuarioss = new Dictionary<IClient, string>();
        public void EnviarMensaje(Mensaje mensaje)
        {
            var enviarA = clientes?.First(c => c.Key == mensaje.paraIdUsuario).Value;
            enviarA?.RecibirMensaje(mensaje);
        }

        public void Conectarse(Jugador jugador)
        {
            callBack = OperationContext.Current.GetCallbackChannel<IClient>();
                          
            if(callBack != null)
            {
                clientes.Add((jugador.idJugador).ToString(), callBack);
                _jugadores.Add(jugador);
                clientes?.ToList().ForEach(c => c.Value.UsuariosConectados(_jugadores));
                Console.WriteLine($"{jugador.nickName} se ha conectado");
            }
        }


        public ObservableCollection<Jugador> GetUsuariosConectados()
        {
           return _jugadores;
        }

        public void Login(String nickName, string contrasenia)
        {
            bool usuarioLogueado = false;
            JugadorDAO usuarioALoguear = new JugadorDAO();

            //string contraseniaEncriptada = string.Empty;
            //byte[] encryted = System.Text.Encoding.Unicode.GetBytes(contrasenia);
            //contraseniaEncriptada = Convert.ToBase64String(encryted);

            usuarioLogueado = usuarioALoguear.ValidarUsuario(nickName, contrasenia);

            if(usuarioLogueado)
            {
                Console.WriteLine("Usuario Logeado");
                Console.WriteLine("Conectando");
                var conexion = OperationContext.Current.GetCallbackChannel<IClient>();
                conexion.VerificarUsuarioLogeado(true);
                Console.WriteLine("Paso de conectando lol");
            }
            else
            {
                Console.WriteLine("No paso Logeado");
            }
        }

        public void CrearJugador(Jugador jugador)
        {
            bool creado = false;
            JugadorDAO jugadorDAO = new JugadorDAO();
            creado = jugadorDAO.Crear(jugador);

            if(creado)
            {
                var conexion = OperationContext.Current.GetCallbackChannel<IClient>();
                conexion.VerificarCreacionJugador(true);
                Console.WriteLine("Jugador creado");
            }
            else
            {
                Console.WriteLine("No se creo");
            }
        }

        class Program
        {
            static void Main(String[] args)
            {
                ServiceHost host = new ServiceHost(typeof(Memorama));
                host.Open();
                Console.WriteLine("El servicio esta listo");
                Console.ReadLine();
                host.Close();
            }
        }
    }

}
