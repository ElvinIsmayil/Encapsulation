using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation2.Models
{
    public class Product
    {
        private double _price;
        private int _count;
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price 
        {
            get => _price;

            set
            {
                if (value < 0)
                {
                    _price = value;
                }
            }
        }

        public int Count
        {
            get => _count;

            set
            {
                if (value < 0)
                {
                    _count = value;
                }
            }
        }

        public Product(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
    }
}
