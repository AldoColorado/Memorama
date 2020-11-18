using System;
using System.Collections.Generic;
using System.Linq;
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
    /// Lógica de interacción para ChatLayout.xaml
    /// </summary>
    public partial class ChatLayout : UserControl
    {
        public ChatLayout()
        {
            InitializeComponent();
        }

        public Label TituloMensaje
        {
            get { return Title;}
            set { Title = value; }
        }

        public Button BotonEnviar
        {
            get { return Enviar; }
            set { Enviar = value; }

        }

        public ScrollViewer ContenidoScrollViewer
        {
            get { return ContentScroller; }
            set { ContentScroller = value; }
        }

        public TextBox ContenidoDelMensaje
        {
            get { return ContenidoMensaje; }
            set { ContenidoMensaje = value;}
        }

        public ItemsControl DespliegueMensaje
        {
            get { return MessageTemplate;}
            set { MessageTemplate = value;}
        }
    }
}
