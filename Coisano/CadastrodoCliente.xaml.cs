using Coisano.Modelos;
using Controles;
using Microsoft.Maui.Controls;

namespace Coisano
{
  
    public partial class CadastrodoCliente : ContentPage
    {
          ClienteControle clienteControle = new ClienteControle();
        public CadastrodoCliente()
        {
            InitializeComponent();
        }

        private void OnCancelClicked(object sender, EventArgs e)
        {
           Application.Current.MainPage = new MainPage();
        }

        private void OnSaveClicked(object sender, EventArgs e)
        {  
             if (string.IsNullOrWhiteSpace(NomeEntry.Text) ||
                string.IsNullOrWhiteSpace(TelefoneEntry.Text) ||
                string.IsNullOrWhiteSpace(CpfEntry.Text) ||
                string.IsNullOrWhiteSpace(EmailEntry.Text) ||
                string.IsNullOrWhiteSpace(CnpjEntry.Text) ||
                string.IsNullOrWhiteSpace(EnderecoEntry.Text)); 

             
              
             
             else
             {
                 var c = new Cliente();
                 c.Nome = NomeEntry.Text;
                 c.Telefone = TelefoneEntry.Text;
                 c.Cpf = CpfEntry.Text;
                 c.Email = EmailEntry.Text;
                 c.Cnpj = CnpjEntry.Text;
                 c.Endereço = EnderecoEntry.Text;
                 clienteControle.CriarOuAtualizar(c);

                Application.Current.MainPage = new CadastrodoProduto();
             }
        }
        
        
    }
}
