using Microsoft.Maui.Controls;

namespace Coisano
{
    public partial class ControledeEstoque : ContentPage
    {
        public ControledeEstoque()
        {
            InitializeComponent();
        }

        private async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            string productCode = ProductCodeEntry.Text;
            string category = CategoryEntry.Text;
            string totalQuantity = TotalQuantityEntry.Text;

            if (string.IsNullOrWhiteSpace(productCode) ||
                string.IsNullOrWhiteSpace(category) ||
                string.IsNullOrWhiteSpace(totalQuantity))
            {
                await DisplayAlert("Erro", "Dados Incorretos!!!", "OK");
            }
            else
            {
                Application.Current.MainPage = new Estoque();
                await DisplayAlert("Sucesso", "Dados salvos com sucesso!", "OK");
            }
        }
    }
}
