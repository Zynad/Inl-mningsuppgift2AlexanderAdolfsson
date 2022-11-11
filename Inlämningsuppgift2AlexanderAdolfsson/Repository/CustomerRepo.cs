using Inlämningsuppgift2AlexanderAdolfsson.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift2AlexanderAdolfsson.Repository
{
    public class CustomerRepo
    {
        private HotelEntities _dbConnection;

        public CustomerRepo()
        {
            _dbConnection = new HotelEntities();
        }

        public List<Customer> GetAllCustomers()
        {
            return _dbConnection.Customer.ToList();
        }
        public List<Customer> GetAllCustomers(string searchCondition)
        {
            return _dbConnection.Customer.Where(c => c.Name.ToLower().Contains(searchCondition.ToLower())).ToList();
        }
        public Customer GetCustomer(int customerID)
        {
            return _dbConnection.Customer.Find(customerID);
        }
        public void DeleteCustomer(int customerID)
        {
            Customer customer = GetCustomer(customerID);
            _dbConnection.Customer.Remove(customer);
            _dbConnection.SaveChanges();
        }
        public void UpdateCustomer(Customer customer)
        {
            Customer orgCustomer = GetCustomer(customer.CustomerID);
            _dbConnection.Entry(orgCustomer).CurrentValues.SetValues(customer);
            _dbConnection.SaveChanges();
        }
        public void InsertCustomer(Customer customer)
        {
            _dbConnection.Customer.Add(customer);
            _dbConnection.SaveChanges();
        }
    }
}
