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
            
            DisplayAlert("Atenção", "Mensagem: Cadastro efetuado, confirme os dados abaixos" + "\n" +txtNome.Text + "\n" + txtIdade.Text + "\n" + txtSexo.Text + "\n" + txtTelefone.Text,"OK","Cancelar");
        }
    }
}
