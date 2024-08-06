using Microsoft.Maui.Controls;

namespace Coisano
{
    public partial class CadastrodoProduto : ContentPage
    {
        public CadastrodoProduto()
        {
            InitializeComponent();
        }

      private void OnCancelClicked(object sender, EventArgs args)
      {
       Application.Current.MainPage = new CadastrodoCliente();
      }
      private void OnSaveClicked(object sender, EventArgs args)
      {
        Application.Current.MainPage = new Viabilidade();
      }
    }
}
