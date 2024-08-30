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

  private void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new CadastrodoCliente();
        }

        private void OnBackButtonClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new ControledeEstoque();
        }

}