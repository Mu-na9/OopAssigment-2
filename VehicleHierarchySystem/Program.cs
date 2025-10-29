using VehicleHierarchySystem.Model;

namespace VehicleHierarchySystem
{
    internal class Program 
    {
        static void Main(string[] args)
       
        {
                Car myCar = new Car("BMW", "BMB", 2025, 2);
                myCar.DisplayInfo();

                Truck myTruck = new Truck("Firary", "FRoo", 2000, 2.5);
                myTruck.DisplayInfo();

                Vehicle vehicle1 = new Car("Honda", "YYT", 2020, 4);
                Vehicle vehicle2 = new Truck("Mercedes", "BENZ", 2022, 4.2);

                vehicle1.DisplayInfo();
                vehicle2.DisplayInfo();

              
                Console.ReadKey();
        }

     }
}

