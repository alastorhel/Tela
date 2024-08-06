using Microsoft.Maui.Controls;

namespace Coisano
{
    public partial class CadastrodaCostureira : ContentPage
    {
        public CadastrodaCostureira()
        {
            InitializeComponent();
        }

        private void OnContinuarSalvarClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NomeEntry.Text) || string.IsNullOrWhiteSpace(TelefoneEntry.Text))
            {
                MensagemErro.IsVisible = true;
            }
            else
            {
                MensagemErro.IsVisible = false;
                Application.Current.MainPage = new EnvioparaoAcabamento();
            }
        }

        private void OnVoltarClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new Vendas();
        }
    }
}
