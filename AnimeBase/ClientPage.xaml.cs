using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using AnimeBase.BackLogic;


namespace AnimeBase
{
    public partial class ClientPage : Page
    {
        public ClientPage()
        {
            InitializeComponent();
            //Определение количества клиентов и отображение на странице
            Client tmp = new Client();
            countOf_.Text = $"{Convert.ToString(tmp.LastNumber())} Клиентов";

            clientsGrid.ItemsSource = tmp.OpenClientList();

            clientsGrid.Items.Filter = FilterMetod;
        }

        private bool FilterMetod(object obj)
        {
            var filterobj = (Client)obj;

            return filterobj.Name.Contains(txtFilter.Text, StringComparison.OrdinalIgnoreCase) || filterobj.Surname.Contains(txtFilter.Text, StringComparison.OrdinalIgnoreCase);
        }
        private void txtFilter_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtFilter.Text == null)
            {
                clientsGrid.Items.Filter = null;
            }
            else
            {
                clientsGrid.Items.Filter = FilterMetod;
            }
        }

        private void closeWinBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void logOut_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AuthPage());
        }
        private void orderBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new OrderPage());
        }
        private void productBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ProductPage());
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            AddClientWindow addClientWindow = new AddClientWindow();
            addClientWindow.ShowDialog();
            Reflesh();
        }
        public void Reflesh()
        {
            Client tmp = new Client();
            countOf_.Text = $"{Convert.ToString(tmp.LastNumber() - 1)} Клиентов";

            clientsGrid.ItemsSource = tmp.OpenClientList();
        }
    }
}
