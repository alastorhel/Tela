using Microsoft.Maui.Controls;

namespace Coisano
{
    public partial class EnvioparaoAcabamento : ContentPage
    {
        public EnvioparaoAcabamento()
        {
            InitializeComponent();
        }

        private void OnSaveButtonClicked(object sender, EventArgs e)
        {
            // Implement your save logic here
            DisplayAlert("Success", "Customer information saved successfully", "OK");
        }

        private void OnBackButtonClicked(object sender, EventArgs e)
        {
            // Implement your back navigation logic here
            Navigation.PopAsync();
        }
    }
}
