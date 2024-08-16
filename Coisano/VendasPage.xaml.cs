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

        private void OnSaveButtonClicked(object sender, EventArgs e)
        {
            if      (string.IsNullOrWhiteSpace(ClienteEntry.Text) ||
                string.IsNullOrWhiteSpace(PedidoEntry.Text) ||
                string.IsNullOrWhiteSpace(DescontoEntry.Text)); 

             

             else
             {
                 var c = new Vendas();
                 c.Cliente = ClienteEntry.Text;
                 c.DatadoPedido = PedidoEntry.Text;
                 c.Desconto = DescontoEntry.Text;
                 vendasControle.CriarOuAtualizar(c);

            Application.Current.MainPage = new CadastrodaCostureiraPage();
            DisplayAlert("Success", "Customer information saved successfully", "OK");
        }
    }
}
}