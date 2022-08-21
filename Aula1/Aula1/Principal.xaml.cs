using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Aula1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Principal : ContentPage
    {
        public Principal()
        {
            InitializeComponent();
            var usuariologado = UsuarioLogado.Instancia;
            lblLogin.Text = "Olá, " + usuariologado.Login;
        }

        private void btnCadastro_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MainPage(), false);
        }
    }
}