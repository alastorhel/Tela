using Microsoft.Maui.Controls;

namespace Coisano
{
    public partial class CadastrodoAcabamentista : ContentPage
    {
        public CadastrodoAcabamentista()
        {
            InitializeComponent();
        }

        private void OnSaveButtonClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new Fim();
            DisplayAlert("Success", "Customer information saved successfully", "OK");
        }

        private void OnBackButtonClicked(object sender, EventArgs e)
        {
             Application.Current.MainPage = new EnvioparaoAcabamento();
            Navigation.PopAsync();
        }
    }
}
