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

        public static bool HasPassed(DateTime dateTime)
        {

        }
    }
}
