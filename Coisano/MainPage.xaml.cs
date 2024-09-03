using Microsoft.Maui.Controls;

namespace Coisano
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnEnterClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new Telainicial();
        }
    }
}
