using Microsoft.Maui.Controls;

namespace Coisano
{
    public partial class Estoque : ContentPage
    {
        public Estoque()
        {
            InitializeComponent();
        }

        private void OnSeguirClicked(object sender, EventArgs e)
        {
            // Implementar a lógica para validar a entrada e definir o resultado
            bool entradaValida = ValidarEntrada();
            
            if (entradaValida)
            {
                ResultadoImagem.Source = "success.png";
                ResultadoTexto.Text = "Feito com Sucesso!!";
            }
            else
            {
                ResultadoImagem.Source = "error.png";
                ResultadoTexto.Text = "Alteração de Estoque Incorreta!!";
            }
            
            Resultado.IsVisible = true;
        }

        private bool ValidarEntrada()
        {
           Application.Current.MainPage = new EnvioparaoCortePage();
            return !string.IsNullOrEmpty(TempoEntrada.Text) && !string.IsNullOrEmpty(QuantidadeAtual.Text);
        }
    }
}
