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
    /// Логика взаимодействия для AddEditPageSotr.xaml
    /// </summary>
    public partial class AddEditPageSotr : Window
    {
        private Staff _currentStaff = new Staff();
        public AddEditPageSotr(Staff SelectedStaff)
        {
            InitializeComponent();
            if (SelectedStaff != null)
                _currentStaff = SelectedStaff;
            DataContext = _currentStaff;
        }

        private void btn_Add_Click(object sender, RoutedEventArgs e)
        {
            if (_currentStaff.IDStaff == 0)
            {
                _ = ZPPrakticaEntities.GetContext().Staff.Add(_currentStaff);
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

        private void btn_Otmena_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
