using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceOrderSystem.Model
{
    public class Product
    {

        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public int Length { get; internal set; }

        public Product()
        {

            Name = " ";
            Price = 0.0;
            Quantity = 0;

        }

        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public virtual double CalculateTotal()
        {
            return Price * Quantity;    
        
        }
        public double CalculateTotal(double price, int quantity)
        { 
          return Price * quantity;  
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"The Product: {Name}");
            Console.WriteLine($"Price: {Price} ");
            Console.WriteLine($"Quantity: {Quantity}");
            Console.WriteLine($"THe totle: {CalculateTotal()}");


        }


    }

}
