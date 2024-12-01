using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace интернет___магазин_с_исп.конструкторов_и_деконструкторов
{
    class Product
    {
        public string Name { get; }
        public double Price { get; }
        public int Quantity { get; }


        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public void Deconstruct(out string name, out double price, out int quantity)
            => (name, price, quantity) = (Name, Price, Quantity);

        public override string ToString()
            => $"{Name} - {Price:C}, {Quantity} шт.";
    }
}
