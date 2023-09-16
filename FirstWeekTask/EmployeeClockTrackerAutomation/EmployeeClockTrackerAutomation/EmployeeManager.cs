using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClockTrackerAutomation
{
    
    public class EmployeeManager
    {
        EmployeeDal _employeeDal;
        public EmployeeManager(EmployeeDal employeeDal)
        {
            _employeeDal = employeeDal;
        }

        public Employee GetEmployeeRecords(int id)
        {
            return _employeeDal.GetById(id);
        }
        public List<Employee> GetAllEmployeeRecords()
        {
            return _employeeDal.GetAll();
        }

        public List<Shift> GetEmployeeShifts(int id)
        {
            return _employeeDal.GetById(id).Shifts;
        }

        public List<double> GetEmployeeOverTimeShifts(int id)
        {
            return _employeeDal.GetById(id).Shifts.Select(s=>(s.End-s.Start).TotalHours).ToList();
        }
    }
}
