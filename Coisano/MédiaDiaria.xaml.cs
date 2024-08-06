using Microsoft.Maui.Controls;

namespace Coisano
{
    public partial class MédiaDiaria : ContentPage
    {
        public MédiaDiaria()
        {
            InitializeComponent();
        }

         private void OnSaveClicked(object sender, EventArgs args)
      {
        Application.Current.MainPage = new Listadeclientes();
      }
    }
}
