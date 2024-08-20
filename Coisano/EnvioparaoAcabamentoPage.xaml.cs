using Controles;
using Microsoft.Maui.Controls;

namespace Coisano
{
    public partial class EnvioparaoAcabamentoPage : ContentPage
    {

        EnvioparaoAcabamentoControle envioparaoAcabamentoControle = new EnvioparaoAcabamentoControle();
        internal int id;

        public EnvioparaoAcabamentoPage()
        {
            InitializeComponent();
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
                var c = new EnvioparaoAcabamentoPage();
                c.Nome = NomeEntry.Text;
                c.Identificaçãodoproduto = IdentificaçãodoprodutoEntry.Text;
                c.Quantidade = QuantidadeEntry.Text;
                envioparaoAcabamentoControle.CriarOuAtualizar(c);

                await DisplayAlert("Dados Corretos!!", "Seus dados foram salvos com Sucesso!!", "OK");

                Application.Current.MainPage = new CadastrodoAcabamentista();
            }

        }




        private void OnBackButtonClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new CadastrodaCostureiraPage();
            Navigation.PopAsync();
        }


    }
}

