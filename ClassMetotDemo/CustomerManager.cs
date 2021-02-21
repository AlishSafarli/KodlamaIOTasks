using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager : ICustomer
    {
        private List<Customer> _customers = null;
        public CustomerManager()
        {
            _customers = new List<Customer>()
            {
                //new Customer{ CustomerID="1", CustomerName="Alish", CustomerSurname="Safarli", CustomerContact="0555333334"}
            };
        }
        public void AddCustomer(Customer entity)
        {
            var checkCustomer = _customers
                .Where(i => i.CustomerID == entity.CustomerID)
                .SingleOrDefault();
            _customers.Add(entity);
        }
        public void DeleteCustomer(Customer entity)
        {
            var deletingCustomer = GetCustomer(entity.CustomerID);
            _customers.Remove(deletingCustomer);
        }
        public void EditCustomer(Customer entity)
        {
            var editingCustomer = GetCustomer(entity.CustomerID);
            editingCustomer.CustomerName = entity.CustomerName;
            editingCustomer.CustomerSurname = entity.CustomerSurname;
            editingCustomer.CustomerContact = entity.CustomerContact;
        }

        public Customer GetCustomer(string id) => 
            _customers
            .Where(i => i.CustomerID == id)
            .FirstOrDefault();
        public List<Customer> GetCustomers() => _customers;
       
    }
}
