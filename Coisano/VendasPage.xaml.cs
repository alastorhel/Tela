using Coisano.Modelos;
using Controles;
using Microsoft.Maui.Controls;

namespace Coisano
{
    public partial class VendasPage : ContentPage
    {
        VendasControle vendasControle = new VendasControle();
        public VendasPage()
        {
            InitializeComponent();
        }

        private async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            if      (string.IsNullOrWhiteSpace(ClienteEntry.Text) ||
                string.IsNullOrWhiteSpace(PedidoEntry.Text) ||
                string.IsNullOrWhiteSpace(DescontoEntry.Text))


                {
                      
               await DisplayAlert("ERRO!!", "Dados inválidos", "OK");
                
            }
             

             else
             {
                 var c = new Vendas();
                 c.Cliente = ClienteEntry.Text;
                 c.DatadoPedido = PedidoEntry.Text;
                 c.Desconto = DescontoEntry.Text;
                 vendasControle.CriarOuAtualizar(c);

                  await DisplayAlert("Dados Corretos!!", "Seus dados foram salvos com Sucesso!!", "OK");

            Application.Current.MainPage = new CadastrodaCostureiraPage();
            DisplayAlert("Success", "Customer information saved successfully", "OK");
        }
    }
}
}