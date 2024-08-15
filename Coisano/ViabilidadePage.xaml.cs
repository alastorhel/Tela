using Coisano.Modelos;
using Controles;
using Microsoft.Maui.Controls;

namespace Coisano
{
    public partial class ViabilidadePage : ContentPage
    {
        ViabilidadeControle viabilidadeControle = new ViabilidadeControle();
        public ViabilidadePage()
        {
            InitializeComponent();
        }

         private void OnCancelClicked(object sender, EventArgs args)
      {  Application.Current.MainPage = new CadastrodoProduto();
     
      }
      private void OnSaveClicked(object sender, EventArgs args)
      {
        if      (string.IsNullOrWhiteSpace(ProdutoEntry.Text) ||
                string.IsNullOrWhiteSpace(ViabilidadeEntry.Text) ||
                string.IsNullOrWhiteSpace(QuantidadeEntry.Text)); 

             

             else
             {
                 var c = new Viabilidade();
                 c.Produto = ProdutoEntry.Text;
                 c.viabilidade = ViabilidadeEntry.Text;
                 c.Quantidade = QuantidadeEntry.Text;
                 viabilidadeControle.CriarOuAtualizar(c);

                Application.Current.MainPage = new MédiaDiariaPage();

      }
        
      }
    }
}
