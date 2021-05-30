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
    /// Логика взаимодействия для Register.xaml
    /// </summary>
    public partial class Register : Page
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Backbtn_Click(object sender, RoutedEventArgs e)
        {
            PagesData.pageframe.Navigate(new Autho());
        }

        private void Registerbtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Logintbx.Text != null && Passwordtbx.Text != null && PasswordConftbx.Text != null && Emailtbx.Text != null)
                {
                    if (Passwordtbx.Text == PasswordConftbx.Text && Emailtbx.Text.Contains("@"))
                    {
                        UserData UserData = new UserData()
                        {
                            Login = Logintbx.Text,
                            Password = Passwordtbx.Text,
                            Email = Emailtbx.Text,
                        };
                        SuperDataBase.DB.UserData.Add(UserData);
                        SuperDataBase.DB.SaveChanges();
                        MessageBox.Show("Вы успешно зарегистрированы", "Поздравляем!");
                        PagesData.pageframe.Navigate(new Autho());
                    }
                    else
                    {
                        MessageBox.Show("Проверьте правильность заполненности полей.", "Ошибка 0.0.0");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
