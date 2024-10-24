using Business;
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

namespace WPFDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        public void btnGet_Click(object sender, RoutedEventArgs e)
        {
            BCustomer bCustomer = new BCustomer();
            var customers = bCustomer.Get();
            dgCustomer.ItemsSource = customers;
        }

        public void SearchName_Click(object sender, RoutedEventArgs e)
        {
            BCustomer bCustomer = new BCustomer();
            string param1 = v1.Text;
            var customers = bCustomer.GetName(param1);
            dgCustomer.ItemsSource = null;
            dgCustomer.ItemsSource = customers;
        }

        private void Crear_Click(object sender, RoutedEventArgs e)
        {
            ViewCreateCustomer view = new ViewCreateCustomer();
            view.Show();
        }

        private void Editar_Click(object sender, RoutedEventArgs e)
        {
            ViewUpdateCustomer view = new ViewUpdateCustomer();
            view.Show();
        }

        private void Eliminar_Click(object sender, RoutedEventArgs e)
        {
            ViewDeleteCustomer view = new ViewDeleteCustomer();
            view.Show();
        }
    }
}