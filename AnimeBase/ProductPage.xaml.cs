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
    public partial class ProductPage : Page
    {
        public ProductPage()
        {
            InitializeComponent();
            //Определение количества продуктов и отображение на странице
            Product tmp = new Product();
            countOf_.Text = $"{Convert.ToString(tmp.LastNumber())} Продуктов";

            productsGrid.ItemsSource = tmp.OpenProductList();

            productsGrid.Items.Filter = FilterMetod;
        }
        private bool FilterMetod(object obj)
        {
            var filterobj = (Product)obj;

            return filterobj.Name.Contains(txtFilter.Text, StringComparison.OrdinalIgnoreCase);
        }
        private void txtFilter_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtFilter.Text == null)
            {
                productsGrid.Items.Filter = null;
            }
            else
            {
                productsGrid.Items.Filter = FilterMetod;
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
        private void orderBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new OrderPage());
        }
        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            AddProductWindow addProductWindow = new AddProductWindow();
            addProductWindow.ShowDialog();
            Reflesh();
        }
        public void Reflesh()
        {
            Product tmp = new Product();
            countOf_.Text = $"{Convert.ToString(tmp.LastNumber() - 1)} Товаров";

            productsGrid.ItemsSource = tmp.OpenProductList();
        }
    }
}
