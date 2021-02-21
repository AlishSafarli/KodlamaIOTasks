using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    //The access modifier for the both classes and interfaces is internal
    interface ICustomer
    {
        List<Customer> GetCustomers();
        Customer GetCustomer(string id);
        void AddCustomer(Customer entity);
        void EditCustomer(Customer entity);
        void DeleteCustomer(Customer entity);

    }
}
