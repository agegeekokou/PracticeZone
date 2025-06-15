using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed
{
    public class RemoteControlCar
    {        
        private int _distanceDriven;
        public int Speed { get; } = 5;
        public int BatteryDrain { get; } = 2;
        public int Battery { get; private set; }

        public RemoteControlCar(int speed, int batteryDrain)
        {
            Speed = speed;
            BatteryDrain = batteryDrain;
            _distanceDriven = 0;
            Battery = 100;
        }

        public void Drive()
        {
            if (Battery >= BatteryDrain)
            {
                _distanceDriven += Speed;
                Battery -= BatteryDrain;
            }

        }

        public int DistanceDriven()
        {
            return _distanceDriven;
        }

        public bool BatteryDrained()
        {
           return BatteryDrain == 0;
        }

        public static RemoteControlCar Nitro()
        {
            return new RemoteControlCar(50, 4);
        }
    }
}
