using Coisano.Modelos;
using Controles;
using Microsoft.Maui.Controls;

namespace Coisano
{
    public partial class CadastrodoAcabamentistaPage : ContentPage
    {
        CadastrodoAcabamentistaControle cadastrodoAcabamentistaControle = new CadastrodoAcabamentistaControle();
        public CadastrodoAcabamentistaPage()
        {
            InitializeComponent();
        }

        private async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NomeEntry.Text) ||
               string.IsNullOrWhiteSpace(TelefoneEntry.Text))

            {
                await DisplayAlert("ERRO!!", "Dados inválidos", "OK");
            }



            else
            {
                var c = new CadastrodoAcabamentista();
                c.Nome = NomeEntry.Text;
                c.Telefone = TelefoneEntry.Text;
                cadastrodoAcabamentistaControle.CriarOuAtualizar(c);

                await DisplayAlert("Dados Corretos!!", "Seus dados foram salvos com Sucesso!!", "OK");
                Application.Current.MainPage = new Fim();

            }
        }

        private void OnBackButtonClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new EnvioparaoAcabamentoPage();
            Navigation.PopAsync();
        }

    }
}