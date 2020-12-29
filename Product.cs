using System;
using System.Collections;
using System.Collections.Generic;

namespace Manage_Products
{
    public class Product
    {
        private string _name;
        private string _description;
        public List<int> Rate;
        public double Price;
        public double _average;
        public string Name 
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public Product()
        {
                
        }
        public Product(string name, string description , double price)
        {
            _name = name;
            _description = description;
            Price = price;
        }

        public string Viewinfo()
        {
            return $"Name: { _name}\nPrice: {Price}\nDescription: {_description}\nAverageRate: {_average}\n";      
        }

        public double CalculatorRate()
        {
            double average = 0;
            for (int i = 0; i < Rate.Count; i++)
            {
                average += Rate[i];
            }
            return _average = average;
        }
    }
}