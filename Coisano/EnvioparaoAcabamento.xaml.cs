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
             Application.Current.MainPage = new CadastrodoAcabamentista();
            DisplayAlert("Success", "Customer information saved successfully", "OK");
        }

        private void OnBackButtonClicked(object sender, EventArgs e)
        {
             Application.Current.MainPage = new CadastrodaCostureira();
            Navigation.PopAsync();
        }
    }
}
