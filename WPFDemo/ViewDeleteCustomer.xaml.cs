using Business;
using Entity;
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

namespace WPFDemo
{
    /// <summary>
    /// Lógica de interacción para ViewDeleteCustomer.xaml
    /// </summary>
    public partial class ViewDeleteCustomer : Window
    {
        public ViewDeleteCustomer()
        {
            InitializeComponent();
        }

        private void Cancelar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Eliminar_Click(object sender, RoutedEventArgs e)
        {
            BCustomer bCustomer = new BCustomer();
            string param1 = Id.Text;

            Customer customer = new Customer();
            customer.CustomerID = param1;

            try
            {
                bCustomer.DeleteCustomer(customer);
                MessageBox.Show("Customer Deleted");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

        }
    }
}
