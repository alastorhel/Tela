using Microsoft.Maui.Controls;

namespace Coisano
{
    public partial class Fim : ContentPage
    {
        public Fim()
        {
            InitializeComponent();
            // Aqui você pode definir os valores para os labels a partir de dados reais
            EmailLabel.Text = "email@exemplo.com"; // Atualize com o email real
            PedidoLabel.Text = "1"; // Atualize com o número do pedido real
            QuantidadeLabel.Text = "20"; // Atualize com a quantidade real
        }

        private void OnVoltarClicked(object sender, EventArgs e)
        {
            // Adicione a lógica para voltar à página anterior aqui
            Navigation.PopAsync();
        }
    }
}
