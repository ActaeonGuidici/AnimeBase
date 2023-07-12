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
using System.Windows.Shapes;
using AnimeBase.BackLogic;

namespace AnimeBase
{
    public partial class AddOrderWindow : Window
    {
        public AddOrderWindow()
        {
            InitializeComponent();
            Client clients = new Client();
            clientComboBox.ItemsSource = clients.OpenClientList();
            Product products = new Product();
            productComboBox.ItemsSource = products.OpenProductList();
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
        private void closeWinBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        public void AddButton_Click(object sender, RoutedEventArgs e)
        {
            //string name = nameTextBlock.Text;
            //double price = Convert.ToDouble(priceTextBlock.Text);
            //int quntity = Convert.ToInt32(quntityTextBlock.Text);
            //string description = descriptionTextBlock.Text;

            //Product tmp = new Product();
            //tmp.AddNewProduct(name, price, quntity, description);

            //this.Close();
        }
    }
}
