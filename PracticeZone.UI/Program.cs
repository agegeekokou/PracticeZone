using AnnalynInfiltration;
using BirdWatcher;
using BookingUpForBeauty;
using JedlikToys;
using NeedForSpeed;
using SqueakyClean;
using System;
using System.Globalization;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;
using RemoteControlCar = NeedForSpeed.RemoteControlCar;

namespace PracticeZone.UI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Appointment.Schedule("7/25/2019 13:45:00"));
            
            Console.ReadKey();
        }
    }
}
