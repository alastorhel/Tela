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
            // Logic to save and continue
        }

        private void OnBackClicked(object sender, EventArgs e)
        {
            // Logic to go back
            Navigation.PopAsync();
        }
    }
}
