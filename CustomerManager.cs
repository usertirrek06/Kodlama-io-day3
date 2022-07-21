using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        //Ekleme Listeleme Silme
        public List<Customer> customers=new List<Customer>();
        public void AddCustomer(Customer customer) 
        {
            customers.Add(customer);
            Console.WriteLine(customer.Name + " " + 
                customer.Surname + " Added to system. ID: " + 
                customer.Id); ;
        }
        public void DeleteCustomer(Customer customer) 
        {
            customers.Remove(customer);
            Console.WriteLine(customer.Name + " " +
                customer.Surname + " Deleted to system. ID: " +
                customer.Id);
        }

        public void ListAllCustomers() 
        {
            foreach (Customer cst in customers)
            {
                Console.WriteLine(cst.Name+ " "+cst.Surname+" "+cst.Id);
            }
        }
        public void ShowBalance(Customer customer) 
        {
            Console.WriteLine(customer.Name + " " +
                customer.Surname + " " +
                customer.Id + " " + 
                customer.Balance +" ");
        }
    }
}
