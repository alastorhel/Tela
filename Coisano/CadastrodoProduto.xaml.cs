using Coisano.Modelos;
using Controles;
using Microsoft.Maui.Controls;

namespace Coisano
{
    public partial class CadastrodoProduto : ContentPage
    {

        ProdutoControle produtoControle = new ProdutoControle();
          public Produto produto { get; set; }
        public CadastrodoProduto()

        {
            InitializeComponent();
        }

      private void OnCancelClicked(object sender, EventArgs args)
      {
       Application.Current.MainPage = new Telainicial();
      }

      
         protected override void OnAppearing()
        {
            base.OnAppearing();

            if (produto != null)
            {
                NomeEntry.Text = produto.Nome;
                DescriçãoEntry.Text = produto.Descrição;
                codIdentificaçaoEntry.Text = produto.Codigo;
                CategoriaEntry.Text = produto.Categoria;
                PreçoUnidadeEntry.Text = produto.PreçoUnidade;
            }
        }

      private async void OnSaveClicked(object sender, EventArgs args)
      {
       
        
             if (string.IsNullOrWhiteSpace(NomeEntry.Text) ||
                string.IsNullOrWhiteSpace(DescriçãoEntry.Text) ||
                string.IsNullOrWhiteSpace(codIdentificaçaoEntry.Text) ||
                string.IsNullOrWhiteSpace(CategoriaEntry.Text) ||
                string.IsNullOrWhiteSpace(PreçoUnidadeEntry.Text))

             {
                await DisplayAlert("ERRO!!", "Dados inválidos", "OK");
             }
              
             
             else
             {
                 var c = new Produto();
                 c.Nome = NomeEntry.Text;
                 c.Descrição = DescriçãoEntry.Text;
                 c.codIdentificaçao = codIdentificaçaoEntry.Text;
                 c.Categoria = CategoriaEntry.Text;
                 c.PreçoUnidade = PreçoUnidadeEntry.Text;
                 produtoControle.CriarOuAtualizar(c);

                 await DisplayAlert("Dados Corretos!!", "Seus dados foram salvos com Sucesso!!", "OK");

                 Application.Current.MainPage = new ListadeProdutosPage();

      }
    }
}

}
