using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Aula1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Clicked(object sender, EventArgs e)
        {
            var infocadastro = Cadastro.Instancia2;
            infocadastro.Nome = txtNome.Text;
            infocadastro.Idade = txtIdade.Text;
            infocadastro.Sexo = txtSexo.Text;
            infocadastro.Telefone = txtTelefone.Text;

            Navigation.PushModalAsync(new InfoCadastro(), false);
        }

        private void btnLimpar_Clicked(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtSexo.Text = "";
            txtIdade.Text = "";
            txtTelefone.Text = "";
        }
    }
}
