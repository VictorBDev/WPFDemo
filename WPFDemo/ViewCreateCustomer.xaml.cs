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
    /// Lógica de interacción para ViewCreateCustomer.xaml
    /// </summary>
    public partial class ViewCreateCustomer : Window
    {
        public ViewCreateCustomer()
        {
            InitializeComponent();
        }

        private void Cancelar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        public void Crear_Click(object sender, RoutedEventArgs e)
        {
            BCustomer bCustomer = new BCustomer();
            string param1 = Name.Text;
            string param2 = Address.Text;
            string param3 = Phone.Text;

            Customer customer = new Customer();
            customer.Name = param1;
            customer.Address = param2;
            customer.Phone = param3;
            try
            {
                bCustomer.CreateCustomer(customer);
                MessageBox.Show("Customer Created");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            
        }
    }
}
