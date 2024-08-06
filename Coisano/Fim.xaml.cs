using Microsoft.Maui.Controls;

namespace Coisano
{
    public partial class Fim : ContentPage
    {
        public Fim()
        {
            InitializeComponent();
        }

        private async void OnVoltarClicked(object sender, EventArgs e)
        {
             Application.Current.MainPage = new CadastrodoCliente();
            await Navigation.PopAsync();
        }
    }
}
