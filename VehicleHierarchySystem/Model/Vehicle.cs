using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleHierarchySystem.Model
{
    public class Vehicle
    {
        public string Make { get; set; }      
        public string Model { get; set; }     
        public int Year { get; set; }         

        public Vehicle(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine("        Vehicle       ");
            Console.WriteLine($"Company Name: {Make}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Year of Manufacturre: {Year}");






        }
    }
}
