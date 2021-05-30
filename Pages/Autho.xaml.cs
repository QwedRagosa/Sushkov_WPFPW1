using Sushkov_WPFPW1.Classes;
using Sushkov_WPFPW1.DataBase;
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

namespace Sushkov_WPFPW1.Pages
{
    /// <summary>
    /// Логика взаимодействия для Autho.xaml
    /// </summary>
    public partial class Autho : Page
    {
        public Autho()
        {
            InitializeComponent();
        }

        private void Registerbtn_Click(object sender, RoutedEventArgs e)
        {
            PagesData.pageframe.Navigate(new Register());
        }

        private void Enterbtn_Click(object sender, RoutedEventArgs e)
        {
            var UserDataVarLogin = SuperDataBase.DB.UserData.FirstOrDefault(x => x.Login == Logintbx.Text && x.Password == Passwordtbx.Text);
            var UserDataVarEmail = SuperDataBase.DB.UserData.FirstOrDefault(x => x.Email == Logintbx.Text && x.Password == Passwordtbx.Text);
            if (UserDataVarLogin != null || UserDataVarEmail != null)
            {
                MessageBox.Show("Вы вошли в пустоту. Привет.", "Успех!");
            }
            else
            {
                MessageBox.Show("Шото не так.", "Ошибка");
            }
        }
    }
}
