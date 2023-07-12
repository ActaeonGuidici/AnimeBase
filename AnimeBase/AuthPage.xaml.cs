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
    /// <summary>
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
        }
        private void minimizeBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }
        private void closeBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void enterBtn_Click(object sender, RoutedEventArgs e)
        {
            string login = loginBox.Text;
            string password = passBox.Password;
            User tmpUser = new User();
            if (tmpUser.Log_In(login, password))
            {
                NavigationService.Navigate(new ClientPage());
            }
            else
            {
                MessageBox.Show("Логин или пароль введены неверно.");

            }
        }
        private void regBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new regPage());
        }
        

    }
}
