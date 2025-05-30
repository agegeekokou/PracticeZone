using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JedlikToys
{
    public class RemoteControlCar
    {
        private int drivenDistance = 0;   
        private int battery = 100;        

        public static RemoteControlCar Buy()
        {
            return new RemoteControlCar();
        }

        public string DistanceDisplay()
        {
            return $"Driven {drivenDistance} meters";
        }

        public string BatteryDisplay()
        {
            return battery > 0 ? $"Battery at {battery}%" : "Battery empty";
        }

        public void Drive()
        {
            if (battery > 0)
            {
                drivenDistance += 20;
                battery -= 1;
            }
        }
    }
}
