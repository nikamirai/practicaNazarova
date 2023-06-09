﻿using System;
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
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void btn_Registration_Click(object sender, RoutedEventArgs e)
        {
            if (tbPassword.Text == tbReturnPassword.Text)
            {
                ZPPrakticaEntities zP = new ZPPrakticaEntities();
                UserSystem userSystem = new UserSystem { NameUser = tbName.Text, SurnameUser = tbSurname.Text, Login = tbLogin.Text, Password = tbPassword.Text, IDTypeUser = 2};
                _ = zP.UserSystem.Add(userSystem);
                _ = zP.SaveChanges();
                MessageBox.Show("Вы зарегистрированы");
            }
            else
            {
                MessageBox.Show("Проверьте пароль");
            }
        }
    }
}
