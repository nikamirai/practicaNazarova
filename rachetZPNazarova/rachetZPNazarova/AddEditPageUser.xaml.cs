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

namespace rachetZPNazarova
{
    /// <summary>
    /// Логика взаимодействия для AddEditPageUser.xaml
    /// </summary>
    public partial class AddEditPageUser : Window
    {
        private UserSystem _currentUser = new UserSystem();
        public AddEditPageUser(UserSystem SelectedUser)
        {
            InitializeComponent();
            if (SelectedUser != null)
                _currentUser = SelectedUser;
            DataContext = _currentUser;
        }

        private void btn_Otmena_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btn_Add_Click(object sender, RoutedEventArgs e)
        {
            if (_currentUser.IDUser == 0)
            {
                _ = ZPPrakticaEntities.GetContext().UserSystem.Add(_currentUser);
            }
            try
            {
                _ = ZPPrakticaEntities.GetContext().SaveChanges();
                _ = MessageBox.Show("Изменения сохранены");
                Close();
                AdminPage adminPage = new AdminPage();
                adminPage.Show();

            }
            catch (Exception ex)
            {
                _ = MessageBox.Show("Ошибка - " + ex.Message.ToString());
            }
        }
    }
}
