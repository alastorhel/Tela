using Coisano.Modelos;
using Controles;
using Microsoft.Maui.Controls;

namespace Coisano
{
    public partial class CadastrodaCostureiraPage : ContentPage
    {
        CadastroCostureiraControle cadastroCostureiraControle = new CadastroCostureiraControle();
        public CadastrodaCostureiraPage()
        {
            InitializeComponent();
        }

        private void OnContinuarSalvarClicked(object sender, EventArgs e)
        {
             if      (string.IsNullOrWhiteSpace(NomeEntry.Text) ||
                string.IsNullOrWhiteSpace(TelefoneEntry.Text)); 

             

             else
             {
                 var c = new CadastroCostureira();
                 c.Nome = NomeEntry.Text;
                 c.Telefone = TelefoneEntry.Text;
        
                 cadastroCostureiraControle.CriarOuAtualizar(c);

            if (string.IsNullOrWhiteSpace(NomeEntry.Text) || string.IsNullOrWhiteSpace(TelefoneEntry.Text))
            {
                MensagemErro.IsVisible = true;
            }
            else
            {
                MensagemErro.IsVisible = false;
                Application.Current.MainPage = new EnvioparaoAcabamento();
            }
        }

       
    }
}


}