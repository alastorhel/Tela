using Microsoft.Maui.Controls;
using System.Collections.Generic;

namespace Coisano
{
    public partial class Listadeclientes : ContentPage
    {
        public Listadeclientes()
        {
            InitializeComponent();
            LoadClients();
        }

        private void LoadClients()
        {
            var clients = GetClients(); // Replace with your data fetching logic

            foreach (var client in clients)
            {
                var clientLayout = new StackLayout
                {
                    Orientation = StackOrientation.Horizontal,
                    Spacing = 10
                };

                var clientIcon = new Image { Source = client.Icon, WidthRequest = 50, HeightRequest = 50 };
                var clientInfoLayout = new StackLayout();
                clientInfoLayout.Children.Add(new Label { Text = client.Name });
                clientInfoLayout.Children.Add(new Label { Text = client.CNPJ });
                clientInfoLayout.Children.Add(new Label { Text = client.RegistrationDate });

                var editButton = new Button { Text = "✏️", BackgroundColor = Colors.Transparent };
                editButton.Clicked += (s, e) => OnEditClientClicked(client);

                var deleteButton = new Button { Text = "🗑️", BackgroundColor = Colors.Transparent };
                deleteButton.Clicked += (s, e) => OnDeleteClientClicked(client);

                var actionButtonsLayout = new StackLayout
                {
                    Orientation = StackOrientation.Horizontal,
                    HorizontalOptions = LayoutOptions.EndAndExpand
                };
                actionButtonsLayout.Children.Add(editButton);
                actionButtonsLayout.Children.Add(deleteButton);

                clientLayout.Children.Add(clientIcon);
                clientLayout.Children.Add(clientInfoLayout);
                clientLayout.Children.Add(actionButtonsLayout);

                ClientList.Children.Add(new Frame
                {
                    BorderColor = Colors.LightGray,
                    CornerRadius = 10,
                    Content = clientLayout
                });
            }
        }

        private void OnSearchButtonPressed(object sender, EventArgs e)
        {
            // Handle search functionality
        }

        private void OnBackButtonClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MédiaDiaria();
        }

        private void OnSaveButtonClicked(object sender, EventArgs e)
        {
          Application.Current.MainPage = new ControledeEstoque();
        }

        private async void OnEditClientClicked(Client client)
        {
            bool confirm = await DisplayAlert("Confirmação", "Tem certeza que deseja editar o cliente?", "SIM", "NÃO");
            if (confirm)
            {
                // Handle edit client functionality
            }
        }

        private async void OnDeleteClientClicked(Client client)
        {
            bool confirm = await DisplayAlert("Confirmação", "Tem certeza que deseja apagar o cliente?", "SIM", "NÃO");
            if (confirm)
            {
                // Handle delete client functionality
            }
        }

        private List<Client> GetClients()
        {
            // Replace with your data fetching logic
            return new List<Client>
            {
                new Client { Name = "Nome do cliente 1", CNPJ = "00.000.000/0001-00", RegistrationDate = "01/01/2021", Icon = "client_icon.png" },
                new Client { Name = "Nome do cliente 2", CNPJ = "00.000.000/0002-00", RegistrationDate = "01/02/2021", Icon = "client_icon.png" },
                new Client { Name = "Nome do cliente 3", CNPJ = "00.000.000/0003-00", RegistrationDate = "01/03/2021", Icon = "client_icon.png" }
            };
        }
    }

    public class Client
    {
        public string Name { get; set; }
        public string CNPJ { get; set; }
        public string RegistrationDate { get; set; }
        public string Icon { get; set; }
    }
}
