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
    /// Lógica de interacción para ViewUpdateCustomer.xaml
    /// </summary>
    public partial class ViewUpdateCustomer : Window
    {
        public ViewUpdateCustomer()
        {
            InitializeComponent();
        }

        private void Cancelar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Editar_Click(object sender, RoutedEventArgs e)
        {
            BCustomer bCustomer = new BCustomer();
            string param1 = Id.Text;
            string param2 = Name.Text;
            string param3 = Address.Text;
            string param4 = Phone.Text;

            Customer customer = new Customer();
            customer.CustomerID = param1;
            customer.Name = param2;
            customer.Address = param3;
            customer.Phone = param4;
            
            try
            {
                bCustomer.UpdateCustomer(customer);
                MessageBox.Show("Customer Updated");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

        }
    }
}
