using System;
using Coisano.Modelos;
using Controles;
using Microsoft.Maui.Controls;

namespace Coisano
{
    public partial class CadastrodoCortadorPage : ContentPage
    {

        CadastrodoCortadorControle cadastrodoCortadorControle = new CadastrodoCortadorControle();
        public CadastrodoCortadorPage()
        {
            InitializeComponent();
        }

        private void OnSaveContinueClicked(object sender, EventArgs e)
        {
              if      (string.IsNullOrWhiteSpace(NomeEntry.Text) ||
                string.IsNullOrWhiteSpace(TelefoneEntry.Text)); 

             

             else
             {
                 var c = new CadastrodoCortador();
                 c.Nome = NomeEntry.Text;
                 c.Telefone = TelefoneEntry.Text;
                 cadastrodoCortadorControle.CriarOuAtualizar(c);

           Application.Current.MainPage = new EnvioParaCosturaPage();
            ErrorLayout.IsVisible = true;
            ErrorLabel.Text = "Cortador(A), não encontrado!!";
        }

       
    }
}
}