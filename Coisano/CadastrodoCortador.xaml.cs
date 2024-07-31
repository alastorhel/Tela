using System;
using Microsoft.Maui.Controls;

namespace Coisano
{
    public partial class CadastrodoCortador : ContentPage
    {
        public CadastrodoCortador()
        {
            InitializeComponent();
        }

        private void OnSaveContinueClicked(object sender, EventArgs e)
        {
            // Logic to save and continue
            ErrorLayout.IsVisible = true;
            ErrorLabel.Text = "Cortador(A), não encontrado!!";
        }

        private void OnBackClicked(object sender, EventArgs e)
        {
            // Logic to go back
            Navigation.PopAsync();
        }
    }
}
