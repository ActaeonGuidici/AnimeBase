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
    /// <summary>
    /// Логика взаимодействия для AddClientWindow.xaml
    /// </summary>
    public partial class AddClientWindow : Window
    {
        public AddClientWindow()
        {
            InitializeComponent();
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
            string name = nameTextBlock.Text;
            string surname = surnameTextBlock.Text;
            string number = numberTextBlock.Text;
            string mail = mailTextBlock.Text;
            string adress = adressTextBlock.Text;

            Client tmp = new Client();
            tmp.AddNewClient(name, surname, number, mail, adress);

            this.Close();
        }
    }
}
