using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed
{
    public class RaceTrack
    {
        private readonly int _distance;

        public RaceTrack(int distance) 
        {
            _distance = distance;
        }

        public bool TryFinishTrack(RemoteControlCar car)
        {
            int requiredDrives = (int)Math.Ceiling((double)_distance / car.Speed);
            int totalBatteryDrain = requiredDrives * car.BatteryDrain;

            return totalBatteryDrain <= car.Battery;
        }
    }
}
