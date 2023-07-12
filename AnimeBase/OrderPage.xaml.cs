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
    public partial class OrderPage : Page
    {
        public OrderPage()
        {
            InitializeComponent();
            //Определение количества клиентов и отображение на странице
            Client tmp = new Client();
            countOf_.Text = $"{Convert.ToString(tmp.LastNumber() - 1)} Заказов";

            //clientsGrid.ItemsSource = orders;

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
        private void clientBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ClientPage());
        }
        private void productBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ProductPage());
        }
    }
}
