using AnnalynInfiltration;
using BirdWatcher;
using JedlikToys;
using NeedForSpeed;
using SqueakyClean;
using System;
using System.Text;
using RemoteControlCar = NeedForSpeed.RemoteControlCar;

namespace PracticeZone.UI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //int speed = 5;
            //int batteryDrain = 2;
            //var car = new RemoteControlCar(speed, batteryDrain);

            //int distance = 1000;
            //var raceTrack = new RaceTrack(distance);
            //Console.WriteLine(raceTrack.TryFinishTrack(car));

            int speed = 5;
            int batteryDrain = 2;
            var car = new RemoteControlCar(speed, batteryDrain);
            var raceTrack = new RaceTrack(200);
            Console.WriteLine(raceTrack.TryFinishTrack(car)); // Outputs: true

            Console.ReadKey();
        }
    }
}
