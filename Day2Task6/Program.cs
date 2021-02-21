using System;

namespace Day2Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Developed by AlishSafarli
             elishseferli@gmail.com
            */

            //I am gettig the data from Repository class
            //ProductLoop();
            int number1 = 10;
            int number2 = 15;
            Console.WriteLine(Add(number1, number2));
            Console.WriteLine(number1);

        }
        private static void ProductLoop()
        {
            Console.WriteLine("With ForEach loop:");
            foreach (var item in Repository.GetAll())
            {
                Console.WriteLine($"{item.ProductID} - {item.ProductName} - {item.UnitPrice}");
            }

            Console.WriteLine("With For loop:");
            Console.WriteLine("***************");
            for (int i = 0; i < Repository.GetAll().Count; i++)
            {
                Console.WriteLine($"{Repository.GetAll()[i].ProductID} " +
                    $"- {Repository.GetAll()[i].ProductName}" +
                    $" - {Repository.GetAll()[i].UnitPrice}");
            }


            Console.WriteLine("With while loop:");
            Console.WriteLine("***************");
            int counter = 0;
            while (counter < Repository.GetAll().Count)
            {
                Console.WriteLine($"{Repository.GetAll()[counter].ProductID} " +
                   $"- {Repository.GetAll()[counter].ProductName}" +
                   $" - {Repository.GetAll()[counter].UnitPrice}");
                counter++;
            }
        }

        public static int Topla(int val, int val2) => val + val2;

        public static int Add(int val, int val2)
        {
            val = 30;
            return val + val2;
        }
    }
}
