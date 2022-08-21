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
    public partial class InfoCadastro : ContentPage
    {
        public InfoCadastro()
        {
            InitializeComponent();
            var infocadastro = Cadastro.Instancia2;
            lblNome.Text = "Nome: " + infocadastro.Nome;
            lblIdade.Text = "Idade: " + infocadastro.Idade;
            lblSexo.Text = "Sexo: " + infocadastro.Sexo;
            lblTelefone.Text = "Telefone: " + infocadastro.Telefone;
        }
    }
}