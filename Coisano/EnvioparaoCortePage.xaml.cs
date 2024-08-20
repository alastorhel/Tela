using System;
using Coisano.Modelos;
using Controles;
using Microsoft.Maui.Controls;

namespace Coisano
{   

    public partial class EnvioparaoCortePage : ContentPage
    {

         EnvioparaoCorteControle envioparaoCorteControle = new EnvioparaoCorteControle();
        public EnvioparaoCortePage()
        {
            InitializeComponent();
        }

        private void OnAddCortadoraClicked(object sender, EventArgs e)
        {
            // Logic to add a Cortadora
            ErrorLayout.IsVisible = true;
            ErrorLabel.Text = "Cortadora não encontrada!";
        }

        private void OnEditMateriaPrimaClicked(object sender, EventArgs e)
        {
            // Logic to edit Matéria Prima
        }

        private void OnDeleteMateriaPrimaClicked(object sender, EventArgs e)
        {
            // Logic to delete Matéria Prima
            ErrorLayout.IsVisible = true;
            ErrorLabel.Text = "Matéria Prima não encontrada!";
        }

        private async void OnSaveContinueClicked(object sender, EventArgs e)
        {
            if      (string.IsNullOrWhiteSpace( CortadoraEntry.Text) ||
                     string.IsNullOrWhiteSpace(QuantidadeEntry.Text) ||
                    string.IsNullOrWhiteSpace(MateriaPrimaEntry.Text))

             
                {
                              await DisplayAlert("ERRO!!", "Dados inválidos", "OK");
                }

             else
             {
                 var c = new EnvioparaoCorte();
                 c.Cortadora = CortadoraEntry.Text;
                 c.MateriaPrima = MateriaPrimaEntry.Text;
                 c.Quantidade = QuantidadeEntry.Text;
                envioparaoCorteControle.CriarOuAtualizar(c);

                await DisplayAlert("Dados Corretos!!", "Seus dados foram salvos com Sucesso!!", "OK");

           Application.Current.MainPage = new CadastrodoCortadorPage();
        }

       
    }
}
}