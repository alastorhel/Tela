using System;
using Microsoft.Maui.Controls;

namespace Coisano
{
    public partial class EnvioparaoCorte : ContentPage
    {
        public EnvioparaoCorte()
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
