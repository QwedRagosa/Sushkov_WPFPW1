using Sushkov_WPFPW1.Classes;
using Sushkov_WPFPW1.Pages;
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

namespace Sushkov_WPFPW1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SuperDataBase.DB = new DataBase.SushkovDB12Entities();
            PagesData.pageframe = Sushkov_WPFPW1;
            Sushkov_WPFPW1.Navigate(new Autho());
        }
    }
}
