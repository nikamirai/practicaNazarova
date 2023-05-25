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
            var user = zp.UserSystem.Where(w=>w.Login == tbLogin.Text && w.Password == tbPassword.Text).FirstOrDefault();
            if (user == null)
            {
                MessageBox.Show("Что-то введено неверно");
            }
            else
            {
                MessageBox.Show("Вы авторизованы");
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
