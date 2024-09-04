using Coisano.Modelos;

namespace Coisano;
public partial class ListadeCostureira : ContentPage
{
  Controles.CadastroCostureiraControle cadastroCostureiraControle = new Controles.CadastroCostureiraControle();

  public CadastroCostureira cadastroCostureira { get; set; }

  public ListadeCostureira()
	{
		InitializeComponent();

    ListaClientes.ItemsSource = cadastroCostureiraControle.LerTodos();
	}

  
  void QuandoSelecionarUmItemNaLista(object sender, SelectedItemChangedEventArgs e)
  {
    
    var page = new CadastrodaCostureiraPage();
    
    page.cadastroCostureira = e.SelectedItem as CadastroCostureira;
   
    Application.Current.MainPage = page;
  }

  void NovoClienteClicked(object sender, EventArgs e)
  {
   
    Application.Current.MainPage = new CadastrodoCliente();
  }

 

       
  
        private void OnVoltarButtonClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new Telainicial();
        }

}