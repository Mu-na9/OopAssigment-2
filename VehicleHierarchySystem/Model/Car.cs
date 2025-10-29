using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleHierarchySystem.Model
{
    public class Car : Vehicle    
    {
        public int NumberOfDoors { get; set; }

        public Car(string make, string model, int year, int numberOfDoors)
            : base(make, model, year)  
        {
            NumberOfDoors = numberOfDoors;
        }
        public override void DisplayInfo()
        {
             base.DisplayInfo();
        }

    }
}
