using SmartHomeDeviceControl.Model.InterFace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeDeviceControl.Model.Class
{
    public class Thermostat : IDevice

    {
        private bool isOn;
        private double currentTemperature;

        public Thermostat(double initialTemp = 22.0)
        {
            isOn = false;
            currentTemperature = initialTemp;
        }

        public void TurnOn()
        {
            isOn = true;
            Console.WriteLine("AC ON");
        }

        public void TurnOff()
        {
            isOn = false;
            Console.WriteLine("AC OFF");
        }

        public void SetStatus()
        {
            string status = isOn ? "on" : "off";

            Console.WriteLine($"AC Status : {status} | Temperature : {currentTemperature}°C");
        }

        public void SetTemperature(double temp)
        {
            if (temp >= 16 && temp <= 30)
            {
                currentTemperature = temp;
                Console.WriteLine($" Temprature changed: {currentTemperature}°C");
            }
            else
            {
                Console.WriteLine("Temprature Must Be Between 16 to 30 °C ");
            }

        }




    }
}
