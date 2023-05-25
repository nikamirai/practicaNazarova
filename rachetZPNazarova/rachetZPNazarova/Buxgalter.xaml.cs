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
    /// Логика взаимодействия для Bukxalter.xaml
    /// </summary>
    public partial class Bukxalter : Window
    {
        public Bukxalter()
        {
            InitializeComponent();
            ZPPrakticaEntities zP = new ZPPrakticaEntities();
            cb.ItemsSource = zP.Staff.ToList();
            cbForma.ItemsSource = zP.TypePoint.ToList();
        }

        private void btn_SdelnoPremial_Click(object sender, RoutedEventArgs e)
        {
            if (premia.Text != "")
            {
                double rez = Convert.ToInt32(sdelnayaRaschenka.Text) * Convert.ToInt32(all_za_Month.Text);
                double zp2 = rez + Convert.ToInt32(premia.Text);
                _ = MessageBox.Show("Заработная плата работника с учетом премии равна:" + " " + zp2);
            }
            else
            {
                double res = Convert.ToInt32(sdelnayaRaschenka.Text) * Convert.ToInt32(all_za_Month.Text);
                _ = MessageBox.Show("Заработная плата работника без премии" + " " + res);
            }
        }

        private void btn_SdelnoProgress_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(all.Text) <= 110)
            {
                double prog = Convert.ToInt32(all.Text) * 80;
                MessageBox.Show("Заработная плата равна " + prog);
            }
            else
            {
                double prog2 = Convert.ToInt32(all.Text) - 110;
                double rez3 = (110 * 80) + Convert.ToInt32(prog2) * 85;
                MessageBox.Show("Зп равна " + rez3);
            }
        }

        private void btn_Cosvennaya_Click(object sender, RoutedEventArgs e)
        {
            double zarab = Convert.ToInt32(zarabotok.Text) / 100;
            double zp4 = zarab * Convert.ToInt32(proz.Text);
            MessageBox.Show("Заработная плата " + zp4);
        }

        private void btn_Simple_Click(object sender, RoutedEventArgs e)
        {
            double stavka = Convert.ToInt32(hourStavka.Text) / Convert.ToInt32(formaVirobotky.Text);
            MessageBox.Show("Сдельная расценка за одно изделие" + stavka);
            double zp = stavka * Convert.ToInt32(VsegoIzgotovil.Text);
            MessageBox.Show("Зп" + " " + zp);
        }

        private void bth_Ras(object sender, RoutedEventArgs e)
        {
            if (cbForma.Text == "Простая")
            {
                Simple.Visibility = Visibility.Visible;

                sdelRaschenka.Visibility = Visibility.Hidden;
                SdelnoProgress.Visibility = Visibility.Hidden;
                cos.Visibility = Visibility.Hidden;
            }
            if (cbForma.Text == "Сдельно-премиальная")
            {
                sdelRaschenka.Visibility = Visibility.Visible;

                Simple.Visibility = Visibility.Hidden;
                SdelnoProgress.Visibility = Visibility.Hidden;
                cos.Visibility = Visibility.Hidden;
            }
            if (cbForma.Text == "Сдельно-прогрессивная")
            {
                SdelnoProgress.Visibility = Visibility.Visible;

                sdelRaschenka.Visibility = Visibility.Hidden;
                Simple.Visibility = Visibility.Hidden;
                cos.Visibility = Visibility.Hidden;
            }
            if (cbForma.Text == "Косвенно-сдельная")
            {
                cos.Visibility = Visibility.Visible;

                sdelRaschenka.Visibility = Visibility.Hidden;
                SdelnoProgress.Visibility = Visibility.Hidden;
                Simple.Visibility = Visibility.Hidden;
            }
        }
    }
}
