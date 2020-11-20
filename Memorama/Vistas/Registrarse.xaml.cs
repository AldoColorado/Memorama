using Modelo.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Memorama.Vistas
{
    /// <summary>
    /// Lógica de interacción para Registrarse.xaml
    /// </summary>
    public partial class Registrarse
    {
        Jugador jugador = new Jugador();
        string codigo = "";
        public Registrarse()
        {
            InitializeComponent();
            
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void EnviarCorreo()
        {
            System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
            GenerarCodigoRegistro();

            
            mail.To.Add(TextoCorreo.Text);
            mail.Subject = "Confirmación de registro en Memorama";
            mail.SubjectEncoding = System.Text.Encoding.UTF8;
            mail.Body = "Tu codigo de confirmación es:" + codigo;
            mail.BodyEncoding = System.Text.Encoding.UTF8;
            mail.IsBodyHtml = true;
            mail.From = new System.Net.Mail.MailAddress("aldocoloradocd@gmail.com");

            System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();

            cliente.Credentials = new System.Net.NetworkCredential("aldocoloradocd@gmail.com", "LesCactus27");

            cliente.Port = 587;
            cliente.EnableSsl = true;

            cliente.Host = "smtp.gmail.com"; //"mail.dominio.com"

            try
            {
                cliente.Send(mail);
            }
            catch(Exception)
            {
                MessageBox.Show("Error al enviar el correo");
            }

        }

        public void GenerarCodigoRegistro()
        {
            var seed = Environment.TickCount;
            var random = new Random(seed);

            for(int i = 0; i <= 4; i++)
            {
                var value = random.Next(0, 9);
                codigo += value;
            }
        }

        private void BotonRegistrarse(object sender, RoutedEventArgs e)
        {
            string contraseniaEncriptada = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(TextoPassword.Password);
            contraseniaEncriptada = Convert.ToBase64String(encryted);
            

            jugador.nickName = TextoNickName.Text;
            jugador.nombre = TextoNombre.Text;
            jugador.correoElectronico = TextoCorreo.Text;
            jugador.contrasenia = contraseniaEncriptada;

            EnviarCorreo();

            ConfirmarRegistro ventanaConfirmarRegistro = new ConfirmarRegistro(jugador,codigo);
            ventanaConfirmarRegistro.Show();
            Window.GetWindow(this).Close();
        }
    }
}
