using Coisano.Modelos;
using Microsoft.Maui.Controls;

namespace Coisano
{
    public partial class Telainicial
    {
        public Telainicial()
        {
            InitializeComponent();
        }
        private void ButtonClienteButtonClicked(object sender, EventArgs args)
        {

            Application.Current.MainPage = new ListadeclientesPage();

        }
        private void ButtonProdutoButtonClicked(object sender, EventArgs args)
        {

            Application.Current.MainPage = new CadastrodoProduto();

        }
          private void ButtonUnidadeButtonClicked(object sender, EventArgs args)
        {

            Application.Current.MainPage = new ViabilidadePage();

        }
        private void ButtonMateriaprimaButtonClicked(object sender, EventArgs args)
        {

            Application.Current.MainPage = new MédiaDiariaPage();

        }
        private void ButtonEnviocorteButtonClicked(object sender, EventArgs args)
        {

            Application.Current.MainPage = new ListadeclientesPage();

        }
        private void ButtonEnviocosturaButtonClicked(object sender, EventArgs args)
        {

            Application.Current.MainPage = new Estoque();

        }
        private void ButtonEnvioacabamentoButtonClicked(object sender, EventArgs args)
        {

            Application.Current.MainPage = new EnvioparaoCortePage();

        }
        private void ButtonVendasButtonClicked(object sender, EventArgs args)
        {

            Application.Current.MainPage = new CadastrodoCortadorPage();

        }

        private void ButtonCortadoresButtonClicked(object sender, EventArgs args)
        {

            Application.Current.MainPage = new EnvioParaCosturaPage();

        }
         private void ButtonCostureirosButtonClicked(object sender, EventArgs args)
        {

            Application.Current.MainPage = new VendasPage();

        }
         private void ButtonAcabamentistasButtonClicked(object sender, EventArgs args)
        {

            Application.Current.MainPage = new CadastrodaCostureiraPage();

        }

        
         private void ButtonEnvioCorteButtonClicked(object sender, EventArgs args)
        {

            Application.Current.MainPage = new EnvioparaoAcabamentoPage();

        }

        private void ButtonAcabamentisstaButtonClicked(object sender, EventArgs args)
        {

            Application.Current.MainPage = new CadastrodoAcabamentistaPage();

        }


    
}
}