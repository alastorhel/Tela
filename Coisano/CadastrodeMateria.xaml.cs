using Coisano.Modelos;
using Microsoft.Maui.Controls;

namespace Coisano
{
    public partial class CadastrodeMateria : ContentPage
    {
        internal CadastroMateriaPrima cadastroMateriaPrima;

        Controles.CadastroMateriaPrimaControle cadastroMateriaPrimaControle= new  Controles.CadastroMateriaPrimaControle();
  

        public CadastrodeMateria()
        {
            InitializeComponent();
        }

        private void OnEditClicked(object sender, EventArgs e)
        {
            ResultadoImagem.Source = "edit_confirm.png";
            ResultadoTexto.Text = "Tem certeza que deseja editar o cliente?";
            ConfirmarSim.IsVisible = true;
            ConfirmarNao.IsVisible = true;
            Resultado.IsVisible = true;
        }

        private void OnDeleteClicked(object sender, EventArgs e)
        {
            ResultadoImagem.Source = "delete_confirm.png";
            ResultadoTexto.Text = "Tem certeza que deseja apagar o cliente?";
            ConfirmarSim.IsVisible = true;
            ConfirmarNao.IsVisible = true;
            Resultado.IsVisible = true;
        }

        private void OnSaveClicked(object sender, EventArgs e)
        {
            // Implementar a lógica para salvar os dados
            bool materiaPrimaEncontrada = ValidarEntrada();
            
            if (!materiaPrimaEncontrada)
            {
                ResultadoImagem.Source = "not_found.png";
                ResultadoTexto.Text = "Matéria Prima não encontrada!!";
                ConfirmarSim.IsVisible = false;
                ConfirmarNao.IsVisible = false;
                Resultado.IsVisible = true;
            }
        }

        private bool ValidarEntrada()
        {
            // Implementar a lógica de validação aqui
            return !string.IsNullOrEmpty(NomeMateriaPrima.Text) && !string.IsNullOrEmpty(UnidadeMedida.Text);
        }

        private void OnConfirmarSimClicked(object sender, EventArgs e)
        {
            // Implementar a lógica para confirmar a ação
            Resultado.IsVisible = false;
        }

        private void OnConfirmarNaoClicked(object sender, EventArgs e)
        {
            Resultado.IsVisible = false;
        }
    }
}
