using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClockTrackerAutomation
{
    public static class DateTimeExtenstion
    {
        public static DateTime ToGermanyTime(this DateTime time)
        {
            return TimeZoneInfo.ConvertTimeBySystemTimeZoneId(time, "Central European Standard Time");
        }
    }
}
