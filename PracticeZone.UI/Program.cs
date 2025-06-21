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
            Console.WriteLine(Appointment.IsAfternoonAppointment(new DateTime(2019, 03, 29, 10, 0, 0)));
            
            Console.ReadKey();
        }
    }
}
