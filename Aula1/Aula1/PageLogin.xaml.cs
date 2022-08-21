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
    public partial class PageLogin : ContentPage
    {
        public PageLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Clicked(object sender, EventArgs e)
        {
            if (ValidarLogin(txtLogin.Text.Trim(), txtSenha.Text.Trim()))  // adicionar Trim excluir espaços, deixando apenas caracteres
            {
                var usuariologado =  UsuarioLogado.Instancia;
                usuariologado.Login = txtLogin.Text;

                Navigation.PushModalAsync(new Principal());
            }
            else
                DisplayAlert("Atenção", "Login ou Senha inválidos!", "Ok");
        }

        bool ValidarLogin(string login, string senha)
        {
            return (login == "admin" && senha == "admin");
        }
    }
}