using Coisano.Modelos;

namespace Coisano;
public partial class ListadeclientesPage : ContentPage
{
  Controles.ClienteControle clienteControle = new Controles.ClienteControle();

  public Cliente cliente { get; set; }

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

 

        private async void OnDeleteButtonClicked(object sender, EventArgs e)
  {
    
    if (cliente == null || cliente.Id < 1)
      await DisplayAlert("Erro", "Nenhum cliente para excluir", "ok");
    else if (await DisplayAlert("Excluir","Tem certeza que deseja excluir esse cliente?","Excluir Cliente","cancelar")) 
    {
      clienteControle.Apagar(cliente.Id);
      
      Application.Current.MainPage = new ListadeclientesPage(); 
    }
  }

        private void OnVoltarButtonClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new Telainicial();
        }

}