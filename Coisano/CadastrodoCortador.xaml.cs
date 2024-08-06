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
           Application.Current.MainPage = new EnvioParaCostura();
            ErrorLayout.IsVisible = true;
            ErrorLabel.Text = "Cortador(A), não encontrado!!";
        }

        private void OnBackClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new Estoque();
            Navigation.PopAsync();
        }
    }
}
