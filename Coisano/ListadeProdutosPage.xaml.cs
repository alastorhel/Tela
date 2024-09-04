using Coisano.Modelos;

namespace Coisano;

public partial class ListadeProdutosPage : ContentPage
{
  Controles.ProdutoControle produtoscontrole = new Controles.ProdutoControle();
  public Produto produto { get; set; }

  public ListadeProdutosPage()
  {
    InitializeComponent();

    ListaClientes.ItemsSource = produtoscontrole.LerTodos();
  }



  void NovoClienteClicked(object sender, EventArgs e)
  {

    Application.Current.MainPage = new CadastrodoProduto();
  }



  void QuandoSelecionarUmItemNaLista(object sender, SelectedItemChangedEventArgs e)
  {


    var page = new CadastrodoProduto();
    page.produto = e.SelectedItem as Produto;
    Application.Current.MainPage = page;


  }

  private void OnVoltarButtonClicked(object sender, EventArgs e)
  {
    Application.Current.MainPage = new Telainicial();
  }

}
