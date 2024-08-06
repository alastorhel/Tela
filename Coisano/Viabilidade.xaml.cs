using Microsoft.Maui.Controls;

namespace Coisano
{
    public partial class Viabilidade : ContentPage
    {
        public Viabilidade()
        {
            InitializeComponent();
        }

         private void OnCancelClicked(object sender, EventArgs args)
      {  Application.Current.MainPage = new CadastrodoProduto();
     
      }
      private void OnSaveClicked(object sender, EventArgs args)
      {
        Application.Current.MainPage = new MédiaDiaria();
      }
    }
}
