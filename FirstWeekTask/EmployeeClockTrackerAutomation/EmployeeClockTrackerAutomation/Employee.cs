using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClockTrackerAutomation
{
    public class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double HourlyPay { get; set; }

        public List<Shift> Shifts { get; set; } = new();

    }
}
