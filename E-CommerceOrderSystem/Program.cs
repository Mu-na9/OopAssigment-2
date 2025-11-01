using E_CommerceOrderSystem.Model;

namespace E_CommerceOrderSystem
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine(".-.-.-.-. WELCOM TO TREND COUTURE .-.-.-.-.\n");
            Console.WriteLine(".-.-.-.-. E-Commerce Order System .-.-.-.-.\n");

            Product product1 = new Product("WINTER ABAYA", 42, 10);
            Product product2 = new Product("EID COLLECTION ABAYA", 38, 15);
           
            Console.WriteLine(".-.-.-.- Individual Products .-.-.-.");
            product1.DisplayInfo();
            product2.DisplayInfo();

            Console.WriteLine($"Calculated with parameters: {product1.CalculateTotal(42, 30)} ");

            Order order = new Order();

            order.AddProduct(product1,
            order.GetProductCount());
            order.AddProduct(product2, order.GetProductCount());
        
       

            // Display order summary
            order.DisplayOrderSummary();

            Console.WriteLine("\n--- Second Order ---");
            Order order2 = new Order("ORD-CUSTOM-001");
            order2.AddProduct(new Product("Monitor", 350.00m, 1), order2.GetProductCount());
            order2.AddProduct(new Product("USB Cable", 5.99m, 10), order2.GetProductCount());
            Console.WriteLine();

            order2.DisplayOrderSummary();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();








            Console.ReadKey();
        }
    }
}
