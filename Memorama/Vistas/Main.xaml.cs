using Modelo;
using Modelo.Modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Lógica de interacción para Main.xaml
    /// </summary>
    public partial class Main : UserControl
    {
        private Jugador jugador;
        private MainWindow mainWindow;
        private ObservableCollection<Mensaje> mensajes;
        private readonly SolidColorBrush[] usuarioBackground = new SolidColorBrush[4];
        private Jugador _jugador;

        public Main(MainWindow window, Jugador jugador)
        {
            InitializeComponent();
            this.mainWindow = window;
            _jugador = jugador;
            mainWindow.Width = 540;
            mainWindow.Height = 400;

            mainWindow.Background = new SolidColorBrush();
            usuarioBackground[0] = new SolidColorBrush(Color.FromArgb(233, 108, 41, 239));
            usuarioBackground[1] = new SolidColorBrush(Color.FromArgb(233, 239, 41, 210));
            usuarioBackground[2] = new SolidColorBrush(Color.FromArgb(233, 73, 44, 130));
            usuarioBackground[3] = new SolidColorBrush(Color.FromArgb(233, 115, 36, 103));
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            Timer timer = new Timer(obj =>
            {
                mainWindow.mainView.Dispatcher.Invoke(() => { 
                                
                });
            }, null, TimeSpan.FromSeconds(1), TimeSpan.FromSeconds(1));
        }

        private void ListBox_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}