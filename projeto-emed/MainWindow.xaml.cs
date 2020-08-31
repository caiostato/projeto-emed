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

namespace projeto_emed
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void openMedicoScreenLogin(object sender, RoutedEventArgs e)
        {
            login_screen_medico objMedicoLoginScreen = new login_screen_medico();

            this.Visibility = Visibility.Hidden;

            objMedicoLoginScreen.Show();
        }

        private void openFarmaceuticoScreenLogin(object sender, RoutedEventArgs e)
        {
            login_screen_farmaceutico objFarmaceuticoLoginScreen = new login_screen_farmaceutico();

            this.Visibility = Visibility.Hidden;

            objFarmaceuticoLoginScreen.Show();
        }

        private void openAdmScreenLogin(object sender, RoutedEventArgs e)
        {
            login_screen_admin objAdmLoginScreen = new login_screen_admin();

            this.Visibility = Visibility.Hidden;

            objAdmLoginScreen.Show();
        }
    }
}
