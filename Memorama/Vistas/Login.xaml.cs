using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data;
using System.ServiceModel;
using Modelo;
using Memorama.Vistas;
using System.Windows;
using System.Windows.Controls;
using Memorama.ModelosDeVista;
using System;
using System.Threading;
using Modelo.Modelo;

namespace Memorama
{
    /// <summary>
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : UserControl , Proxy.IServiceCallback
    {
        public bool Aceptado { get; set; }
        private MainWindow mainWindow;


        public Login()
        {
            InitializeComponent();
            //mainWindow = (MainWindow)Application.Current.MainWindow;
            //if(mainWindow != null)
            //{
            //    mainWindow.Width = 540;
            //    mainWindow.Height = 420;
            //    mainWindow.MinWidth = 540;
            //    mainWindow.MinHeight = 420;
            //    mainWindow.MaxWidth = 540;
            //    mainWindow.MaxHeight = 420;
            //}
        }

        private void BotonAceptar_Click(object sender, RoutedEventArgs e)
        {

            Jugador jugador= new Jugador();

            jugador.nickName = TextoNickName.Text;
            jugador.contrasenia = TextoPassword.Password;

            mainWindow.mainView = new Main(mainWindow, jugador);
            InstanceContext contexto = new InstanceContext(new Login());
            Proxy.ServiceClient servidor = new Proxy.ServiceClient(contexto);

            servidor?.Login(TextoNickName.Text, TextoPassword.Password);
            
            servidor?.Conectarse(jugador);
            mainWindow.Main.Children.Clear();
            mainWindow.Main.Children.Add(mainWindow.mainView);
            
            
        }

        public void RecibirMensaje(Mensaje mensaje)
        {
            throw new NotImplementedException();
        }

        public void UsuariosConectados(Jugador[] usuarios)
        {
                   
        }

        public void VerificarUsuarioLogeado(bool logeado)
        {
            this.Aceptado = true;
        }

        private void BotonRegistrarse(object sender, RoutedEventArgs e)
        {
            Registrarse ventanaRegistro = new Registrarse();
            ventanaRegistro.Show();
            Window.GetWindow(this).Close();
        }

        public void VerificarCreacionJugador(bool creado)
        {
            //throw new NotImplementedException();
        }
    }
}
