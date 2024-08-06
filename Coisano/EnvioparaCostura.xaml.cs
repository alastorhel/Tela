using System;
using Microsoft.Maui.Controls;

namespace Coisano
{
    public partial class EnvioParaCostura : ContentPage
    {
        public EnvioParaCostura()
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
           Application.Current.MainPage = new Vendas();
        }

        private void OnBackClicked(object sender, EventArgs e)
        {
             Application.Current.MainPage = new CadastrodoCortador();
            Navigation.PopAsync();
        }
    }
}
