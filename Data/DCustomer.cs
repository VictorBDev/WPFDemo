using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DCustomer
    {
        string cadena = "Data Source=RED\\SQLEXPRESS;Initial Catalog=Pluton;User ID=userVictor;Password=123456;";


        public List<Customer> Get()
        {
            SqlConnection connection = new SqlConnection(cadena);
            connection.Open();
            SqlCommand cmd = new SqlCommand("USP_ReadCustomer", connection);
            List<Customer> listCustomer = new List<Customer>();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Customer customer = new Customer();
                customer.CustomerID = reader["customer_id"].ToString();
                customer.Name = reader["name"].ToString();
                customer.Address = reader["address"].ToString();
                customer.Phone = reader["phone"].ToString();
                customer.Active = reader["active"].ToString();
                listCustomer.Add(customer);
            }
            connection.Close(); 
            return listCustomer;
        }

        public List<Customer> GetName(string param1)
        {
            SqlConnection connection = new SqlConnection(cadena);
            connection.Open();
            SqlCommand cmd = new SqlCommand("USP_SearchCustomer", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parametro1 = new SqlParameter("@Name", SqlDbType.VarChar, 255);
            parametro1.Value = param1;
            cmd.Parameters.Add(parametro1);

            List<Customer> listCustomer = new List<Customer>();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Customer customer = new Customer();
                customer.CustomerID = reader["customer_id"].ToString();
                customer.Name = reader["name"].ToString();
                customer.Address = reader["address"].ToString();
                customer.Phone = reader["phone"].ToString();
                customer.Active = reader["active"].ToString();
                listCustomer.Add(customer);
            }
            connection.Close();
            return listCustomer;
        }

        public void DeleteCustomer(Customer customer)
        {
            SqlConnection connection = new SqlConnection(cadena);
            connection.Open();
            SqlCommand cmd = new SqlCommand("USP_DeleteCustomer", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parametro1 = new SqlParameter("@CustomerId", SqlDbType.VarChar, 5);
            parametro1.Value = customer.CustomerID;
            cmd.Parameters.Add(parametro1);
            cmd.ExecuteReader();
            connection.Close();
        }

        public void CreateCustomer(Customer customer)
        {
            SqlConnection connection = new SqlConnection(cadena);
            connection.Open();
            SqlCommand cmd = new SqlCommand("USP_CreateCustomer", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parametro1 = new SqlParameter("@Name", SqlDbType.VarChar, 225);
            parametro1.Value = customer.Name;
            SqlParameter parametro2 = new SqlParameter("@Address", SqlDbType.VarChar, 225);
            parametro2.Value = customer.Address;
            SqlParameter parametro3 = new SqlParameter("@Phone", SqlDbType.VarChar, 15);
            parametro3.Value = customer.Phone;

            cmd.Parameters.Add(parametro1);
            cmd.Parameters.Add(parametro2);
            cmd.Parameters.Add(parametro3);

            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public void UpdateCustomer(Customer customer)
        {
            SqlConnection connection = new SqlConnection(cadena);
            connection.Open();
            SqlCommand cmd = new SqlCommand("USP_UpdateCustomer", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parametro1 = new SqlParameter("@CustomerId", SqlDbType.VarChar, 5);
            parametro1.Value = customer.CustomerID;
            SqlParameter parametro2 = new SqlParameter("@Name", SqlDbType.VarChar, 225);
            parametro2.Value = customer.Name;
            SqlParameter parametro3 = new SqlParameter("@Address", SqlDbType.VarChar, 225);
            parametro3.Value = customer.Address;
            SqlParameter parametro4 = new SqlParameter("@Phone", SqlDbType.VarChar, 15);
            parametro4.Value = customer.Phone;

            cmd.Parameters.Add(parametro1);
            cmd.Parameters.Add(parametro2);
            cmd.Parameters.Add(parametro3);
            cmd.Parameters.Add(parametro4);

            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}
