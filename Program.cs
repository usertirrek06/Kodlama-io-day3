using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Name = "Mehmet";
            customer1.Surname = "Yılmaz";
            customer1.Id = 0;
            customer1.Balance = 0;

            Customer customer2 = new Customer();
            customer2.Name = "Veli";
            customer2.Surname = "Güneş";
            customer2.Id = 1;
            customer2.Balance = 10000;

            Customer customer3 = new Customer();
            customer3.Name = "Suzan";
            customer3.Surname = "Kardeş";
            customer3.Id = 2;
            customer3.Balance = 500;

            CustomerManager customerManager = new CustomerManager();

            customerManager.AddCustomer(customer1);
            customerManager.AddCustomer(customer2);
            customerManager.AddCustomer(customer3);
            Console.WriteLine();
            customerManager.ListAllCustomers();
            Console.WriteLine();
            customerManager.DeleteCustomer(customer2);
            Console.WriteLine();
            customerManager.ListAllCustomers();
            Console.WriteLine();
            customerManager.ShowBalance(customer3);
        }
    }
}
