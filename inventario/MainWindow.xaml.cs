using inventario.Models;
using inventario.Views;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace inventario
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        
            frame_principal.Navigate(new Categoria_todos());
        }




        private void btn_informatica(object sender, RoutedEventArgs e)
        {
            frame_principal.Navigate(new Categoria_informatica());
        }

        private void btn_iniciar_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           

        }
    }
}


