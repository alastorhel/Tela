using Microsoft.Maui.Controls;

namespace Coisano
{
    public partial class Vendas : ContentPage
    {
        public Vendas()
        {
            InitializeComponent();
        }

        private void OnSaveButtonClicked(object sender, EventArgs e)
        {
            // Implement your save logic here
            DisplayAlert("Success", "Customer information saved successfully", "OK");
        }
    }
}
