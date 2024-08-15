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

         private void OnSaveClicked(object sender, EventArgs args)
      {
        if      (string.IsNullOrWhiteSpace( ClienteEntry.Text) ||
                string.IsNullOrWhiteSpace(mediadiariaEntry.Text)); 

             

             else
             {
                 var c = new MediaDiaria();
                 c.Cliente = ClienteEntry.Text;
                 c.mediadiaria = mediadiariaEntry.Text;
                 mediadiáriaControle.CriarOuAtualizar(c);

                Application.Current.MainPage = new Listadeclientes();
      }
       
      }
    }
}
