using Coisano.Modelos;
using Controles;
using Microsoft.Maui.Controls;

namespace Coisano
{
    public partial class MédiaDiariaPage : ContentPage
    {
       MediaDiariaControle mediadiáriaControle = new MediaDiariaControle();
        public MédiaDiariaPage()
        {
            InitializeComponent();
        }

         private async void OnSaveClicked(object sender, EventArgs args)
      {
        if      (string.IsNullOrWhiteSpace( ClienteEntry.Text) ||
                string.IsNullOrWhiteSpace(mediadiariaEntry.Text))

                {
                     await DisplayAlert("ERRO!!", "Dados inválidos", "OK");
                }

             

             else
             {
                 var c = new MediaDiaria();
                 c.Cliente = ClienteEntry.Text;
                 c.mediadiaria = mediadiariaEntry.Text;
                 mediadiáriaControle.CriarOuAtualizar(c);

                  await DisplayAlert("Dados Corretos!!", "Seus dados foram salvos com Sucesso!!", "OK");

                Application.Current.MainPage = new Listadeclientes();
      }
       
      }
    }
}
