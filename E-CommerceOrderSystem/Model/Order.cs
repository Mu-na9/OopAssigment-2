using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceOrderSystem.Model
{
    public class Order
    {
        public Product[] products { get; set; }
        public string OrderNumber  { get; set; }  
        public DateTime OrderDate { get; set; }

        private int productCount;

        public Order(int maxProducts)

        { 
            products = new Product[maxProducts];
            OrderNumber = GenerateOrderNumber();
            OrderDate = DateTime.Now;
            productCount = 0;   
        
        }

        public Order(string orderNumber, int maxProducts)
        {
            products = new Product[maxProducts];
            OrderNumber = orderNumber;
            OrderDate = DateTime.Now;
            productCount = 0;
        }
        private string GenerateOrderNumber()
        {
            return $"ORD - {DateTime.Now:ddmmyyhhmm}";

        }
         public override double calclateTotale ()
        public int CalculateOrderTotrle()  
        {
            return productCount;
        }

        public int GetProductCount()
        {
            return productCount;
        }

        public bool AddProduct(Product Product, int productCount)
        {
            if (productCount < Product.Length)  
            {
                products[productCount] = Product;
                productCount++; 
                
                Console.WriteLine($" {Product.Name} added to your cart");
                return true;
            }
            else
            {
                Console.WriteLine($" Can not add {Product.Name}. Sold out (^_^) ");
                return false;

            }
        }

        public decimal CalculateOrderTotal()
        {
            decimal total = 0;
            for (int i = 0; i < productCount; i++)
            {
                total +=  new  Product[i].CalculateTotal();
            }
            return total;
        }
        public void DisplayOrderSummary()
        {
            Console.WriteLine("\n Order summry ");
            Console.WriteLine($"Abaya Number: {OrderNumber}");
            Console.WriteLine($"Order Date: {OrderDate:dd/MM/yyyy HH:mm}");
            Console.WriteLine($"Abaya in Order: {productCount}/{products.Length}");
            Console.WriteLine(".-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-..-.-.-.-\n");

            if (productCount == 0)
            {
                Console.WriteLine("No Abaya in this order.");
                return;
            }

            Console.WriteLine("Products:");

            for (int i = 0; i < productCount; i++)
            {
                Console.WriteLine($"{i + 1}. {products[i].Name}");
                Console.WriteLine($"   Price: {products[i].Price} x {products[i].Quantity}");
                Console.WriteLine($"   Subtotal: {products[i].CalculateTotal()}");
                Console.WriteLine();
            }

            Console.WriteLine($"TOTAL COST: {CalculateOrderTotal()}");
          
        }

    
        public void DisplayProducts()
        {
            Console.WriteLine("\n.-.-.-.-. Your Abaya in Order .-.-.-.-.");
            for (int i = 0; i < productCount; i++)
            {
                Console.WriteLine($"[{i}] {products[i].Name} - {products[i].Price}");
            }
            Console.WriteLine();

        }


    }
}
