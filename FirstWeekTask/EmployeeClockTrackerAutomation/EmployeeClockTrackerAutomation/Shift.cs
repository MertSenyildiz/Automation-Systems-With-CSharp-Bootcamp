using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClockTrackerAutomation
{
    public class Shift
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public List<Break> Breaks { get; set; } = new();
    }
}
