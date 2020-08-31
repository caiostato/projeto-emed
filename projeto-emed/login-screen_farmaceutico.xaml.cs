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
    /// Lógica interna para login_screen_farmaceutico.xaml
    /// </summary>
    public partial class login_screen_farmaceutico : Window
    {
        public login_screen_farmaceutico()
        {
            InitializeComponent();
        }

        private void backChooseLoginScreenFarmaco(object sender, RoutedEventArgs e)
        {
            MainWindow objMainWidow = new MainWindow();
            this.Visibility = Visibility.Hidden;
            objMainWidow.Show();
        }
    }
}
