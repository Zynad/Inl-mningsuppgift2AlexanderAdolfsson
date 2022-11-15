using Inlämningsuppgift2AlexanderAdolfsson.Models;
using System.Collections.Generic;
using System.Linq;

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
            return _dbConnection.Customers.ToList();
        }
        public List<Customer> GetAllCustomers(string searchCondition)
        {
            return _dbConnection.Customers.Where(c => c.Name.ToLower().Contains(searchCondition.ToLower())).ToList();
        }
        public Customer GetCustomer(int customerID)
        {
            return _dbConnection.Customers.Find(customerID);
        }
        public void DeleteCustomer(int customerID)
        {
            Customer customer = GetCustomer(customerID);
            _dbConnection.Customers.Remove(customer);
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
            _dbConnection.Customers.Add(customer);
            _dbConnection.SaveChanges();
        }
    }
}
