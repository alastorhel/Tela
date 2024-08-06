using Microsoft.Maui.Controls;

namespace Coisano
{
    public partial class CadastrodoCliente : ContentPage
    {
        public CadastrodoCliente()
        {
            InitializeComponent();
        }

        private void OnCancelClicked(object sender, EventArgs e)
        {
           Application.Current.MainPage = new MainPage();
        }

        private void OnSaveClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new CadastrodoProduto();
        }
    }
}
