using System;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace ClassMetotDemo
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Bank Customer Service");

            CustomerManager manager = new CustomerManager();

            if (manager.GetCustomers().Any())
            {
                //a void method that displays existing customers

                DisplayCustomers(manager);

                Console.WriteLine("Add More? Yes -1 , No - 0");
                int yesNo = int.Parse(Console.ReadLine());
                if (yesNo == 1 || yesNo == 0)
                {
                    if (yesNo == 1)
                    {
                        Console.WriteLine("--------------------------------");

                        Customer entity = new Customer();
                        Console.WriteLine("Customer Id");
                        entity.CustomerID = Console.ReadLine();
                        Console.WriteLine("Customer Name");
                        entity.CustomerName = Console.ReadLine();
                        Console.WriteLine("Customer Surname");
                        entity.CustomerSurname = Console.ReadLine();
                        Console.WriteLine("Customer Contact");
                        entity.CustomerContact = Console.ReadLine();

                        try
                        {
                            manager.AddCustomer(entity);
                            Console.Clear();
                            DisplayCustomers(manager);
                        }
                        catch (Exception)
                        {

                            throw;
                        }
                    }
                    else
                    {
                        Environment.Exit(0);
                    }

                }
            }
            else
            {
                Console.WriteLine("No Customer found, do you want add some?If yes type 1 if no type 0");
                int yesNo = int.Parse(Console.ReadLine());

                if (yesNo == 1 || yesNo == 0)
                {
                    if (yesNo == 1)
                    {
                        Console.WriteLine("--------------------------------");

                        Customer entity = new Customer();
                        Console.WriteLine("Customer Id");
                        entity.CustomerID = Console.ReadLine();
                        Console.WriteLine("Customer Name");
                        entity.CustomerName = Console.ReadLine();

                        Console.WriteLine("Customer Surname");
                        entity.CustomerSurname = Console.ReadLine();
                        Console.WriteLine("Customer Contact");
                        entity.CustomerContact = Console.ReadLine();

                        try
                        {
                            manager.AddCustomer(entity);
                            Console.Clear();
                            DisplayCustomers(manager);

                        }
                        catch (Exception)
                        {

                            throw;
                        }
                    }
                    else
                    {
                        Environment.Exit(0);
                    }

                }
                else
                {
                    Console.WriteLine("You can either choose 1 or 0 to continue");
                }

            }

        }


        static void DisplayCustomers(CustomerManager manager)
        {
            Console.WriteLine("Customers:");
            foreach (var item in manager.GetCustomers())
            {
                Console.WriteLine(
                   item.CustomerID + " " +
                    item.CustomerName + " " +
                    item.CustomerSurname + " " +
                    item.CustomerContact);
            }
        }
    }
}
