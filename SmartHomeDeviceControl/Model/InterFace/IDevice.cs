using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeDeviceControl.Model.InterFace
{
    public interface IDevice    
    {

        void TurnOn();
        void TurnOff();
        void SetStatus(string status);

    }
}
