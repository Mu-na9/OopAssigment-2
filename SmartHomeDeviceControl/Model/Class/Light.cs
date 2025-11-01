using SmartHomeDeviceControl.Model.InterFace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeDeviceControl.Model.Class
{
    public class Light : IDevice
    {

        private bool isOn;  
        private int brightnessLevel;    

        public Light(initialBrigtness)
        {
            isOn = false;  
            brightnessLevel = initialBrigtness;
        }   

        public void TurnOn()
        {
            isOn = true;
            Console.WriteLine("Light is turned ON.");
        }

        public void TurnOff() 
        {
            isOn = false;
            Console.WriteLine("Light is turned OFF.");
        }   

        public void SetStatus()
        {
            string status = isOn ? "ON" : "OFF";
            Console.WriteLine($" Light is {status} with brightness level: {brightnessLevel}%."); 

        }

        public void BrightnessLevel(int level)
        {
            brightnessLevel = level;
            Console.WriteLine($"Brightness level is {brightnessLevel}%.");
        }




    }

    public class initialBrigtness
    {
    }
}
