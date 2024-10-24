using Data;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class BCustomer
    {
        public List<Customer> Get()
        {
            DCustomer dCustomer = new DCustomer();
            var customers = dCustomer.Get();
            return customers;
        }

        public List<Customer> GetName(string param1) 
        { 
            DCustomer dCustomer = new DCustomer();
            var customers = dCustomer.GetName(param1);
            return customers;
        }

        public void DeleteCustomer(Customer customer)
        {
            DCustomer dCustomer = new DCustomer();
            dCustomer.DeleteCustomer(customer);
        }

        public void CreateCustomer(Customer customer) 
        {
            DCustomer dCustomer = new DCustomer();
            dCustomer.CreateCustomer(customer);
        }

        public void UpdateCustomer(Customer customer)
        {
            DCustomer dCustomer = new DCustomer();
            dCustomer.UpdateCustomer(customer);
        }

    }
}
