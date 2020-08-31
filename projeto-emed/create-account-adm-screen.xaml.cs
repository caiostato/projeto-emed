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
    /// Lógica interna para create_account_adm_screen.xaml
    /// </summary>
    public partial class create_account_adm_screen : Window
    {
        public create_account_adm_screen()
        {
            InitializeComponent();
        }

        private void backAdmScreen(object sender, RoutedEventArgs e)
        {
            admin_screen_loggedin obj = new admin_screen_loggedin();
            this.Visibility = Visibility.Hidden;
            obj.Show();
        }
    }
}
