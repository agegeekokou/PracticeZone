using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JedlikToys
{
    public class RemoteControlCar
    {
        public static RemoteControlCar Buy()
        {
            return new RemoteControlCar();
        }

        public string DistanceDisplay()
         {
            int totalDistance = 20;
            bool numberOfCall = Convert.ToBoolean(Drive());

            if (Boolean.TryParse(Drive(), out numberOfCall))
            {
                //numberOfCall++;
                totalDistance += totalDistance;
            }

            //foreach (int drive in Drive() )
            //{
            //    totalDistance += drive;             
            //}

            return $"Driven {totalDistance} meters";
        }

        public string BatteryDisplay()
        {
            int battery = 100;
            Console.WriteLine($"Battery at {battery}%");

            return $"Battery at {battery}%";
        }

        public string Drive()
        {
            int drivenDistance = 20;
            
            Console.WriteLine($"Driven {drivenDistance} meters");

            return $"Driven {drivenDistance} meters";
        }
    }
}
