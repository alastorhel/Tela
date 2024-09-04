using Coisano.Modelos;

namespace Coisano;
public partial class ListadeAcabamentista : ContentPage
{
  Controles.CadastrodoAcabamentistaControle cadastrodoAcabamentistaControle = new Controles.CadastrodoAcabamentistaControle();

  public CadastrodoAcabamentista cadastrodoAcabamentista { get; set; }

  public ListadeAcabamentista()
	{
		InitializeComponent();

    ListaClientes.ItemsSource = cadastrodoAcabamentistaControle.LerTodos();
	}

  
  void QuandoSelecionarUmItemNaLista(object sender, SelectedItemChangedEventArgs e)
  {
    
    var page = new CadastrodoAcabamentistaPage();
    
    page.cadastrodoAcabamentista = e.SelectedItem as CadastrodoAcabamentista;
   
    Application.Current.MainPage = page;
  }

  void NovoClienteClicked(object sender, EventArgs e)
  {
   
    Application.Current.MainPage = new CadastrodoCliente();
  }

 

        private async void OnDeleteButtonClicked(object sender, EventArgs e)
  {
    
    if (cadastrodoAcabamentista == null || cadastrodoAcabamentista.Id < 1)
      await DisplayAlert("Erro", "Nenhum cliente para excluir", "ok");
    else if (await DisplayAlert("Excluir","Tem certeza que deseja excluir esse cliente?","Excluir Cliente","cancelar")) 
    {
      cadastrodoAcabamentistaControle.Apagar(cadastrodoAcabamentista.Id);
      
      Application.Current.MainPage = new ListadeclientesPage(); 
    }
  }

        private void OnVoltarButtonClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new Telainicial();
        }

}