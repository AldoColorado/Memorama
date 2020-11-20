using Modelo.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Memorama.Vistas
{
    /// <summary>
    /// Lógica de interacción para ConfirmarRegistro.xaml
    /// </summary>
    public partial class ConfirmarRegistro: Proxy.IServiceCallback
    {
        public bool creado { get; set; }
        private string codigo;
        Jugador jugador = new Jugador();

        public ConfirmarRegistro(Jugador jugador, string codigoConfirmacion)
        {
            InitializeComponent();
            this.codigo = codigoConfirmacion;
            this.jugador = jugador;
        }

        public void RecibirMensaje(Mensaje mensaje)
        {
            throw new NotImplementedException();
        }

        public void UsuariosConectados(Jugador[] jugadores)
        {
            throw new NotImplementedException();
        }

        public void VerificarCreacionJugador(bool creado)
        {
            this.creado = creado;
        }

        public void VerificarUsuarioLogeado(bool logeado)
        {
            throw new NotImplementedException();
        }

        private void BotonConfirmarRegistro(object sender, RoutedEventArgs e)
        {
            if(codigo == TextoCodigo.Text)
            {
                InstanceContext contexto = new InstanceContext(new Login());
                Proxy.ServiceClient servidor = new Proxy.ServiceClient(contexto);

                servidor?.CrearJugador(jugador);
                MessageBox.Show("Registro completado con exito");
                
                
                //MainWindow nuevaVentana = new MainWindow();
                //nuevaVentana.Show();
                //Window.GetWindow(this).Close();

            }
            else
            {
                MessageBox.Show("El codigo ingresado no coincide con el que te fue proporcionado");
            }
        }

    }
}
