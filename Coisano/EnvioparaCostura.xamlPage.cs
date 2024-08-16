using System;
using Coisano.Modelos;
using Controles;
using Microsoft.Maui.Controls;

namespace Coisano
{
    public partial class EnvioParaCosturaPage : ContentPage
    {
        EnvioParaCosturaControle envioparacosturaControle = new EnvioParaCosturaControle();
        public EnvioParaCosturaPage()
        {
            InitializeComponent();
        }

        private void OnAddCostureiraClicked(object sender, EventArgs e)
        {
            // Logic to add a Costureira
            ErrorLayout.IsVisible = true;
            ErrorLabel.Text = "Costureira(O), não encontrada!!";
        }

        private void OnSaveContinueClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CostureiraEntry.Text) ||
                string.IsNullOrWhiteSpace(MateriaPrimaEntry.Text) ||
                string.IsNullOrWhiteSpace(QuantidadeEntry.Text))
            {

            }


            else
            {
                var c = new EnvioParaCostura();
                c.Costureira = CostureiraEntry.Text;
                c.MateriaPrima = MateriaPrimaEntry.Text;
                c.Quantidade = QuantidadeEntry.Text;
                envioparacosturaControle.CriarOuAtualizar(c);
                Application.Current.MainPage = new VendasPage();
            }
        }

        private void OnBackClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new CadastrodoCortadorPage();
            Navigation.PopAsync();
        }

    }


}
