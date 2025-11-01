using SmartHomeDeviceControl.Model.Class;

namespace SmartHomeDeviceControl
{
    internal class Program
    {

        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine(".-.-.-.-. Welcom to Smart Home Device Control ");
          
            Light livingRoomLight = new Light(70);
            Thermostat bedroomThermostat = new Thermostat(24.0);

            Controller lightController = new Controller(livingRoomLight);
            
            lightController.OperateDevice();
            livingRoomLight.SetBrightness(90);
            lightController.CheckDevice();
            lightController.StopDevice();

            Console.WriteLine();

    
            Controller thermoController = new Controller(bedroomThermostat);
            thermoController.OperateDevice();
            bedroomThermostat.SetTemperature(20.5);
            thermoController.CheckDevice();
            thermoController.StopDevice();



            Console.ReadKey();
        }
    }
}
