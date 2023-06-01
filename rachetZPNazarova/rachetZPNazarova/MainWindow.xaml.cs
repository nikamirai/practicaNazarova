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

namespace rachetZPNazarova
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_EnterToSystem_Click(object sender, RoutedEventArgs e)
        {
            ZPPrakticaEntities zp = new ZPPrakticaEntities();
            UserSystem user = zp.UserSystem.Where(w => w.Login == tbLogin.Text && w.Password == tbPassword.Text).FirstOrDefault();
            if (user == null)
            {
                _ = MessageBox.Show("Что-то введено неверно");
            }
            else
            {
                if (user.IDTypeUser == 1)
                {
                    _ = MessageBox.Show("Вы авторизованы");
                    AdminPage adminPage = new AdminPage();
                    adminPage.Show();
                    return;
                }
                else if (user.IDTypeUser == 2)
                {
                    _ = MessageBox.Show("Вы авторизованы");
                    Bukxalter bukxalter = new Bukxalter();
                    bukxalter.Show();
                    return;
                }
            }
        }

        private void btn_Registration_Click(object sender, RoutedEventArgs e)
        {
            Registration registration = new Registration();
            this.Close();
            registration.Show();
            return;
        }
    }
}
