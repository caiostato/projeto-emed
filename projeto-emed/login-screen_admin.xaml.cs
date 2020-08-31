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

namespace projeto_emed
{
    /// <summary>
    /// Lógica interna para login_screen_admin.xaml
    /// </summary>
    public partial class login_screen_admin : Window
    {
        public login_screen_admin()
        {
            InitializeComponent();
        }

        private void backChooseLoginScreenAdm(object sender, RoutedEventArgs e)
        {
            MainWindow objMainWidow = new MainWindow();
            this.Visibility = Visibility.Hidden;
            objMainWidow.Show();
        }

        private void admLoginSucess(object sender, RoutedEventArgs e)
        {
            admin_screen_loggedin obj = new admin_screen_loggedin();
            this.Visibility = Visibility.Hidden;
            obj.Show();
        }
    }
}
