using AnnalynInfiltration;
using BirdWatcher;
using JedlikToys;
using SqueakyClean;
using System;
using System.Text;

namespace PracticeZone.UI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var car = RemoteControlCar.Buy();
            car.Drive();
            car.Drive();
                            
            Console.WriteLine(car.DistanceDisplay()); 
            Console.WriteLine(car.BatteryDisplay()); 
      
            Console.ReadKey();
        }
    }
}
