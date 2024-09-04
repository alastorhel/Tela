using Coisano.Modelos;
using Controles;
using Microsoft.Maui.Controls;

namespace Coisano
{
    public partial class CadastrodaCostureiraPage : ContentPage
    {
        CadastroCostureiraControle cadastroCostureiraControle = new CadastroCostureiraControle();
        public CadastroCostureira cadastroCostureira { get; set; }
        public CadastrodaCostureiraPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (cadastroCostureira != null)
            {
                NomeEntry.Text = cadastroCostureira.Nome;
                TelefoneEntry.Text = cadastroCostureira.Telefone;
            }
        }

        private async void OnContinuarSalvarClicked(object sender, EventArgs e)
        {
             if      (string.IsNullOrWhiteSpace(NomeEntry.Text) ||
                string.IsNullOrWhiteSpace(TelefoneEntry.Text))


                
                {
                      
               await DisplayAlert("ERRO!!", "Dados inválidos", "OK");
                
            }

             

             else
             {
                 var c = new CadastroCostureira();
                 c.Nome = NomeEntry.Text;
                 c.Telefone = TelefoneEntry.Text;
        
                 cadastroCostureiraControle.CriarOuAtualizar(c);

                  await DisplayAlert("Dados Corretos!!", "Seus dados foram salvos com Sucesso!!", "OK");


            if (string.IsNullOrWhiteSpace(NomeEntry.Text) || string.IsNullOrWhiteSpace(TelefoneEntry.Text))
            {
                MensagemErro.IsVisible = true;
            }
            else
            {
                MensagemErro.IsVisible = false;
                Application.Current.MainPage = new ListadeCostureira();
            }
        }

       
    }
}


}