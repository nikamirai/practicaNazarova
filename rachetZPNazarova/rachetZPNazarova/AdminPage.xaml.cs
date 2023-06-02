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
    /// Логика взаимодействия для AdminPage.xaml
    /// </summary>
    public partial class AdminPage : Window
    {
        public AdminPage()
        {
            InitializeComponent();
            DGSotr.ItemsSource = ZPPrakticaEntities.GetContext().Staff.ToList();
            DGUser.ItemsSource = ZPPrakticaEntities.GetContext().UserSystem.ToList();
        }

        private void btn_Edit_User_Information_Click(object sender, RoutedEventArgs e)
        {
            AddEditPageUser addEdit = new AddEditPageUser((sender as Button).DataContext as UserSystem);
            Close();
            addEdit.Show();
            return;
        }

        private void btn_Edit_Sotr_Information_Click(object sender, RoutedEventArgs e)
        {
            AddEditPageSotr addEdit = new AddEditPageSotr((sender as Button).DataContext as Staff);
            Close();
            addEdit.Show();
            return;
        }

        private void btn_Add_New_User_Click(object sender, RoutedEventArgs e)
        {
            AddEditPageUser addEdit = new AddEditPageUser((sender as Button).DataContext as UserSystem);
            Close();
            addEdit.Show();
            return;
        }

        private void btn_Add_New_Sotr_Click(object sender, RoutedEventArgs e)
        {
            AddEditPageSotr addEdit = new AddEditPageSotr((sender as Button).DataContext as Staff);
            Close();
            addEdit.Show();
            return;
        }

        private void btn_Delete_User_Click(object sender, RoutedEventArgs e)
        {
            var productForRemoving = DGUser.SelectedItems.Cast<UserSystem>().ToList();
            ZPPrakticaEntities.GetContext().UserSystem.RemoveRange(productForRemoving);
            ZPPrakticaEntities.GetContext().SaveChanges();
            MessageBox.Show("Данные удалены");
            DGUser.ItemsSource = ZPPrakticaEntities.GetContext().UserSystem.ToList();
        }

        private void btn_Delete_Sotr_Click(object sender, RoutedEventArgs e)
        {
            var productForRemoving = DGSotr.SelectedItems.Cast<Staff>().ToList();
            ZPPrakticaEntities.GetContext().Staff.RemoveRange(productForRemoving);
            ZPPrakticaEntities.GetContext().SaveChanges();
            MessageBox.Show("Данные удалены");
            DGSotr.ItemsSource = ZPPrakticaEntities.GetContext().Staff.ToList();
        }
    }
}
