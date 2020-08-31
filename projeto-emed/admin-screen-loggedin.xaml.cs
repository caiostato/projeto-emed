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
    /// Lógica interna para admin_screen_loggedin.xaml
    /// </summary>
    public partial class admin_screen_loggedin : Window
    {
        public admin_screen_loggedin()
        {
            InitializeComponent();
        }

        private void backLoginScreenAdm(object sender, RoutedEventArgs e)
        {
            login_screen_admin obj = new login_screen_admin();
            this.Visibility = Visibility.Hidden;
            obj.Show();

        }

        private void createAccountButton(object sender, RoutedEventArgs e)
        {
            create_account_adm_screen obj = new create_account_adm_screen();
            this.Visibility = Visibility.Hidden;
            obj.Show();
        }
    }
}
