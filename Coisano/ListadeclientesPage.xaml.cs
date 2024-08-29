using Coisano.Modelos;

namespace Coisano;
public partial class ListadeclientesPage : ContentPage
{
  Controles.ClienteControle clienteControle = new Controles.ClienteControle();

  public ListadeclientesPage()
	{
		InitializeComponent();

    ListaClientes.ItemsSource = clienteControle.LerTodos();
	}

  
  void QuandoSelecionarUmItemNaLista(object sender, SelectedItemChangedEventArgs e)
  {
    
    var page = new CadastrodoCliente();
    
    page.cliente = e.SelectedItem as Cliente;
   
    Application.Current.MainPage = page;
  }

  void NovoClienteClicked(object sender, EventArgs e)
  {
   
    Application.Current.MainPage = new CadastrodoCliente();
  }

  private async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NomeEntry.Text) ||
                string.IsNullOrWhiteSpace(IdentificaçãodoprodutoEntry.Text) ||
                string.IsNullOrWhiteSpace(QuantidadeEntry.Text))

            {
                await DisplayAlert("ERRO!!", "Dados inválidos", "OK");
            }



            else
            {
                var c = new EnvioparaoAcabamento();
                c.Nome = NomeEntry.Text;
                c.Identificaçãodoproduto = IdentificaçãodoprodutoEntry.Text;
                c.Quantidade = QuantidadeEntry.Text;
                envioparaoAcabamentoControle.CriarOuAtualizar(c);

                await DisplayAlert("Dados Corretos!!", "Seus dados foram salvos com Sucesso!!", "OK");

                Application.Current.MainPage = new CadastrodoAcabamentistaPage();
            }

        }

}