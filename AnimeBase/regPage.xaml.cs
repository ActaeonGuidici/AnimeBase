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
    /// Логика взаимодействия для regPage.xaml
    /// </summary>
    public partial class regPage : Page
    {
        public regPage()
        {
            InitializeComponent();
        }
        private void enterBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AuthPage());
        }
        private void minimizeBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }
        private void closeBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void regBtn_Click(object sender, RoutedEventArgs e)
        {
            bool tmp = true;
            User tmpUser = new User();
            string login = loginBox.Text;
            string password = passBox.Password;
            string password2 = passBox2.Password;
            string mail = mailBox.Text;
            if (login.Length < 5)
            {
                loginBox.ToolTip = "Длина логина не может быть меньше 5 символов.";
                loginBox.Background = Brushes.Red;
                tmp = false;
            }
            else if (tmpUser.CheckLogin(login))
            {
                loginBox.ToolTip = "Данный логин уже занят.";
                loginBox.Background = Brushes.Red;
                tmp = false;
            }
            else
            {
                loginBox.ToolTip = "";
                loginBox.Background = Brushes.LightGreen;
            }
            if (password.Length < 5)
            {
                passBox.ToolTip = "Длина пароля не может быть меньше 5 символов.";
                passBox.Background = Brushes.Red;
                tmp = false;
            }
            else
            {
                passBox.ToolTip = "";
                passBox.Background = Brushes.LightGreen;
            }
            if (password != password2)
            {
                passBox2.ToolTip = "Введенные пароли не идентичны.";
                passBox2.Background = Brushes.Red;
                tmp = false;
            }
            else
            {
                passBox2.ToolTip = "";
                passBox2.Background = Brushes.LightGreen;
            }
            if (mail.Length < 7 || !mail.Contains("@") || !mail.Contains("."))
            {
                mailBox.ToolTip = "Адресс почты введен некорректно.";
                mailBox.Background = Brushes.Red;
                tmp = false;
            }
            else
            {
                mailBox.ToolTip = "";
                mailBox.Background = Brushes.LightGreen;
            }

            if (tmp == true)
            {
                User user = new User(login, password, mail);
                tmpUser.AddUser(user);
                MessageBox.Show("Регистрация прошла успешно!");
            }
        }

    }
}
