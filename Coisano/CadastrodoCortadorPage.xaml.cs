using System;
using Coisano.Modelos;
using Controles;
using Microsoft.Maui.Controls;

namespace Coisano
{
    public partial class CadastrodoCortadorPage : ContentPage
    {

        CadastrodoCortadorControle cadastrodoCortadorControle = new CadastrodoCortadorControle();
        public CadastrodoCortadorPage()
        {
            InitializeComponent();
        }

        private async void OnSaveContinueClicked(object sender, EventArgs e)
        {
              if      (string.IsNullOrWhiteSpace(NomeEntry.Text) ||
                string.IsNullOrWhiteSpace(TelefoneEntry.Text))

                 {
                              await DisplayAlert("ERRO!!", "Dados inválidos", "OK");
                }
             

             else
             {
                 var c = new CadastrodoCortador();
                 c.Nome = NomeEntry.Text;
                 c.Telefone = TelefoneEntry.Text;
                 cadastrodoCortadorControle.CriarOuAtualizar(c);

                 
                await DisplayAlert("Dados Corretos!!", "Seus dados foram salvos com Sucesso!!", "OK");

           Application.Current.MainPage = new EnvioParaCosturaPage();
            ErrorLayout.IsVisible = false;
            ErrorLabel.Text = "Cortador(A), não encontrado!!";
            
        }

       
    }
}
}