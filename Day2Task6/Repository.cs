using System;
using System.Collections.Generic;
using System.Text;

namespace Day2Task6
{
    public static class Repository
    {
        private static List<Product> products = null;
        static Repository()
        {
            products = new List<Product>
            {
                new Product{ProductID=1, ProductName="Acer Notebook", UnitPrice=500},
                new Product{ProductID=2, ProductName="Iphone 6", UnitPrice=250},
                new Product{ProductID=3, ProductName="Gorgonzola Telino", UnitPrice=12.5M},
                new Product{ProductID=4, ProductName="Samsung LED TV", UnitPrice=1500},
                new Product{ProductID=5, ProductName="Jack's New England Clam Chowder", UnitPrice=9.65M},
                new Product{ProductID=6, ProductName="Outback Lager", UnitPrice=74M},
                new Product{ProductID=7, ProductName="Bicycle", UnitPrice=150M},
                new Product{ProductID=8, ProductName="ChewingGum", UnitPrice=1.5M},
                new Product{ProductID=9, ProductName="Longlife Tofu", UnitPrice=10},
            };
        }

        public static List<Product> GetAll()
        {
            return products;
        }
    }
}
