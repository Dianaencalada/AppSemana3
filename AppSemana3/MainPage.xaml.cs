using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppSemana3
{
    public partial class MainPage : ContentPage
    {
        public static String NombreUsuario = "estudiante2022";

        public MainPage()
        {
            InitializeComponent();

        }

        private async void btnAbrir_Clicked(object sender, EventArgs e)
        {
            string usuario = txtUser.Text;
            string clave = txtPass.Text;

            if ((usuario == "estudiante2022") && (clave == "uisrael2022"))
            {
                await Navigation.PushAsync(new Pagina2(usuario, clave));
            }
            else
            {
                lblLogin.Text = "El usuario o contraseña es incorrecto";
            }




        }
    }
}
