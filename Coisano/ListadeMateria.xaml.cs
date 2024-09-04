using Coisano.Modelos;

namespace Coisano;

public partial class ListadeMateria : ContentPage
{
  Controles.CadastroMateriaPrimaControle cadastroMateriaPrimaControle= new  Controles.CadastroMateriaPrimaControle();
  
  public CadastroMateriaPrima cadastroMateriaPrima { get; set; }

  public ListadeMateria()
  {
    InitializeComponent();

    ListaClientes.ItemsSource = cadastroMateriaPrimaControle.LerTodos();
  }



  void NovoClienteClicked(object sender, EventArgs e)
  {

    Application.Current.MainPage = new CadastrodeMateria();
  }



  void QuandoSelecionarUmItemNaLista(object sender, SelectedItemChangedEventArgs e)
  {


    var page = new CadastrodeMateria();
    page. cadastroMateriaPrima = e.SelectedItem as CadastroMateriaPrima;
    Application.Current.MainPage = page;


  }

  private void OnVoltarButtonClicked(object sender, EventArgs e)
  {
    Application.Current.MainPage = new Telainicial();
  }

}
