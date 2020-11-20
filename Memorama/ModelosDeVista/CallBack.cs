using Memorama.Proxy;
using Modelo;
using Modelo.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Memorama.ModelosDeVista
{

    public partial class CallBack :Proxy.IServiceCallback
    {
        public void RecibirMensaje(Mensaje mensaje)
        {

        }

        public void UsuariosConectados(Jugador[] usuarios)
        {

        }

        public void VerificarCreacionJugador(bool creado)
        {
            throw new NotImplementedException();
        }

        public void VerificarUsuarioLogeado(bool logeado)
        {

        }
    }
}
