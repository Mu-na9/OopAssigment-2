using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleHierarchySystem.Model
{
    public class Truck : Vehicle
    {

        public double LoadCapacity { get; set; }
    public Truck(string make, string model, int year, double loadCapacity) 
        : base(make, model, year)  
    {
        LoadCapacity = loadCapacity;
    }

            public override void DisplayInfo()
            {
              base.DisplayInfo(); 
               
            }
   
    }
}
