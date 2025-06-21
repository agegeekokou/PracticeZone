using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingUpForBeauty
{
    public class Appointment
    {
        public static DateTime Schedule(string dateTime)
        {
            return Convert.ToDateTime(dateTime, CultureInfo.InvariantCulture);
        }

        public static bool HasPassed(DateTime appointment)
        {
            return appointment < DateTime.Now;
        }

        public static bool IsAfternoonAppointment(DateTime appointment)
        {
            if(appointment.Hour >= 12 && appointment.Hour < 18)
            {
                return true;
            }

            return false;
        }
    }
}
