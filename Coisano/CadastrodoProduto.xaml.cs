using Coisano.Modelos;
using Controles;
using Microsoft.Maui.Controls;

namespace Coisano
{
    public partial class CadastrodoProduto : ContentPage
    {

        ProdutoControle produtoControle = new ProdutoControle();
        public CadastrodoProduto()
        {
            InitializeComponent();
        }

      private void OnCancelClicked(object sender, EventArgs args)
      {
       Application.Current.MainPage = new CadastrodoProduto();
      }
      private void OnSaveClicked(object sender, EventArgs args)
      {
       
        
             if (string.IsNullOrWhiteSpace(NomeEntry.Text) ||
                string.IsNullOrWhiteSpace(DescriçãoEntry.Text) ||
                string.IsNullOrWhiteSpace(codIdentificaçaoEntry.Text) ||
                string.IsNullOrWhiteSpace(CategoriaEntry.Text) ||
                string.IsNullOrWhiteSpace(PreçoUnidadeEntry.Text)); 

             
              
             
             else
             {
                 var c = new Produto();
                 c.Nome = NomeEntry.Text;
                 c.Descrição = DescriçãoEntry.Text;
                 c.codIdentificaçao = codIdentificaçaoEntry.Text;
                 c.Categoria = CategoriaEntry.Text;
                 c.PreçoUnidade = PreçoUnidadeEntry.Text;
                 produtoControle.CriarOuAtualizar(c);

                 Application.Current.MainPage = new Viabilidade();

      }
    }
}

}
