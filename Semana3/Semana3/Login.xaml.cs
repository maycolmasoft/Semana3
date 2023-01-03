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


            string usuario = "estudiante2022";
            string clave = "uisrael2022";

            if (txtUsuario.Text == usuario && txtClave.Text == clave)
            {

                Navigation.PushAsync(new Notas(usuario));

            }
            else {

                DisplayAlert("Alerta","Usuario o Contraseña Incorrectos","cerrar");
            }

        }
    }
}