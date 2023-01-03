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
    public partial class Notas : ContentPage
    {
        public Notas(string usuario)
        {
            InitializeComponent();
            lblUsuario.Text = usuario;
        }

        private void BtnCalcular_Clicked(object sender, EventArgs e)
        {
            double dato1 = Convert.ToDouble(n_seguimiento_1.Text);
            double dato2 = Convert.ToDouble(n_examen_1.Text);

            double dato3 = Convert.ToDouble(n_seguimiento_2.Text);
            double dato4 = Convert.ToDouble(n_examen_2.Text);

            double parcial1 = (dato1 * 0.3) + (dato2 * 0.2);
            n_parcial_1.Text = parcial1.ToString();

            double parcial2 = (dato3 * 0.3) + (dato4 * 0.2);
            n_parcial_2.Text = parcial2.ToString();

            double resultado = parcial1 + parcial2;

            var texto = "";

            if (resultado <= 4.9)
            {

                texto = "PERDIO SEMESTRE";
                n_final.Text = texto;
                n_final.TextColor = Color.Red;

            }
            else if (resultado >= 5 && resultado <= 6.9)
            {


                texto = "EXAMEN COMPLEMENTARIO";
                n_final.Text = texto;
                n_final.TextColor = Color.Yellow;
            }
            else
            {

                texto = "APROBO SEMESTRE";
                n_final.Text = texto;
                n_final.TextColor = Color.Green;
            }





        }

        private void n_seguimiento_1_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double dato11 = Convert.ToDouble(n_seguimiento_1.Text);

                if (dato11 > 10)
                {
                    DisplayAlert("Validación", "Íngrese Numero de 0 a 10", "cerrar");
                    n_seguimiento_1.Text = "".ToString();
                }
            }
            catch
            {

            }




        }

        private void n_examen_1_TextChanged(object sender, TextChangedEventArgs e)
        {


            try
            {
                double dato22 = Convert.ToDouble(n_examen_1.Text);

                if (dato22 > 10)
                {
                    DisplayAlert("Validación", "Íngrese Numero de 0 a 10", "cerrar");
                    n_examen_1.Text = "".ToString();
                }

            }
            catch
            {

            }
        }

        private void n_seguimiento_2_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double dato33 = Convert.ToDouble(n_seguimiento_2.Text);

                if (dato33 > 10)
                {
                    DisplayAlert("Validación", "Íngrese Numero de 0 a 10", "cerrar");
                    n_seguimiento_2.Text = "".ToString();
                }

            }
            catch
            {

            }
        }

        private void n_examen_2_TextChanged(object sender, TextChangedEventArgs e)
        {

            try
            {
                double dato44 = Convert.ToDouble(n_examen_2.Text);

                if (dato44 > 10)
                {
                    DisplayAlert("Validación", "Íngrese Numero de 0 a 10", "cerrar");
                    n_examen_2.Text = "".ToString();
                }

            }
            catch
            {

            }
        }
    
}
}