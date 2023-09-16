using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EmployeeClockTrackerAutomation
{
    public class EmployeeDal
    {
        List<Employee> _employees;
        static EmployeeDal instance = null;
        public static EmployeeDal Instance
        {
            get
            {
                if (instance == null)
                    instance = new EmployeeDal();
                return instance;
            }
        }
        private EmployeeDal()
        {
            _employees = new List<Employee>();
            AddEmployees();
            AddShifts();
        }
        private void AddEmployees()
        {
            string[] names = 
                {"Dirk Kuester",
                    "Christian Pfeffer",
                    "Swen Holtzmann",
                    "Ulrich Brauer",
                    "Maik Pfeifer",
                    "Ralf Eisenhower",
                    "Michael Krause",
                    "Kristian Holzman",
                    "Mario Abt",
                    "Jan Krueger",
                    "Stefan Freud",
                    "David Holzman",
                    "Marko Wulf",
                    "Stefan Moench",
                    "Wolfgang Berg",
                    "Marco Glockner",
                    "David Holtzmann",
                    "Benjamin Eichel",
                    "Dennis Gruenewald",
                    "Martin Wannemaker"};
           for(int i=0;i<names.Length;i++)
           {
                string[] flNames = names[i].Split(' ');
                Employee emp = new Employee() { ID=i,
                    FirstName = flNames[0], 
                    LastName = flNames[1],
                    HourlyPay=new Random().Next(8,15)};
                _employees.Add(emp);
           }
        }
        private void AddShifts()
        {
            foreach(Employee emp in _employees)
            {
                Shift shift = new Shift();
                shift.Start = DateTime.ParseExact($"15.09.2023 08:00:00", "G", CultureInfo.CurrentCulture)
                    .AddHours(new Random().Next(0,6)).AddMinutes(new Random().Next(0,60)).ToGermanyTime();
                shift.End=shift.Start.AddHours(new Random().Next(6, 12)).AddMinutes(new Random().Next(0,60));
                int breakTime=new Random().Next(1,4);
                for(int i = 0; i < breakTime; i++)
                {
                    Break timeoff=new Break();
                    var lastBreak = shift.Breaks.LastOrDefault();
                    if(lastBreak is not null)
                    {
                        timeoff.Start = lastBreak.End.AddHours(new Random().Next(1,4));
                        timeoff.End = timeoff.Start.AddMinutes(new Random().Next(15, 90));
                    }
                    else
                    {
                        timeoff.Start = shift.Start.AddHours(new Random().Next(1, 4));
                        timeoff.End = timeoff.Start.AddMinutes(new Random().Next(15, 90));
                    }
                    var timeDiff=(shift.End -timeoff.End).TotalMinutes;
                    if(timeDiff > 0)
                    {
                        shift.Breaks.Add(timeoff);
                    }

                }
                emp.Shifts.Add(shift);

            }
        }

        public List<Employee> GetAll()
        {
            return _employees;
        }

        public Employee GetById(int id)
        {
            return _employees.FirstOrDefault(e => e.ID == id);
        }
    }
}
