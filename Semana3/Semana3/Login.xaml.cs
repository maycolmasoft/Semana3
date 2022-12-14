using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Semana3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIniciar_Clicked(object sender, EventArgs e)
        {


            string usuario = "12345";
            string clave = "12345";

            if (txtUsuario.Text == usuario && txtClave.Text == clave)
            {

                Navigation.PushAsync(new Principal(usuario));

            }
            else {

                DisplayAlert("Alerta","Usuario o Contraseña Incorrectos","cerrar");
            }

        }
    }
}