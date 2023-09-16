using System.Globalization;

namespace EmployeeClockTrackerAutomation
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            var employeeDal = EmployeeDal.Instance;
            //var list = employeeDal.GetAll();
            //foreach (var item in list)
            //{
            //    Console.WriteLine($"{item.ID}\t {item.FirstName}");
            //    foreach(var shift in item.Shifts)
            //    {
            //        Console.WriteLine($"Shift started at {shift.Start}");
            //        foreach(var br in shift.Breaks)
            //        {
            //            Console.WriteLine($"Break started at {br.Start}\t ended at {br.End}");
            //        }
            //        Console.WriteLine($"Shift ended at {shift.End}");
            //    }
            //}

            EmployeeManager manager = new(employeeDal);
            while (true)
            {
                PrintOptions();
                int option = Int32.Parse(Console.ReadLine());
                switch( option )
                {
                    case 1:
                        ListEmpoyees(manager);
                        break;
                    case 2:
                        GetEmployeeRecords(manager);
                        break;
                    case 3:
                        return;
                    default:
                        Console.WriteLine("Not an option");
                        break;
                }
            }
        }
        static void PrintOptions()
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("1.List All Employees");
            Console.WriteLine("2.Get Employee Records");
            Console.WriteLine("3.Exit");
            Console.Write("Option:");
        }
        static void ListEmpoyees(EmployeeManager manager)
        {
            var list = manager.GetAllEmployeeRecords();
            Console.WriteLine("--------------Employees------------");
            foreach(var e in list)
            {
                Console.WriteLine($"{e.ID}\t{e.FirstName}\t{e.LastName}\t{e.HourlyPay}$");
            }
        }
        static void GetEmployeeRecords(EmployeeManager manager)
        {
            Console.Write("Empoyee Id:");
            int id= Int32.Parse(Console.ReadLine());
            var emp=manager.GetEmployeeRecords(id);
            if(emp is null)
            {
                Console.WriteLine("-------Not Found--------");
                return;
            }
            Console.WriteLine("--------------Employee------------");
            Console.WriteLine($"{emp.ID}\t{emp.FirstName}\t{emp.LastName}\t{emp.HourlyPay}$");
            Console.WriteLine("--------------Shifts------------");
            var st=manager.GetEmployeeShifts(id);
            var ot=manager.GetEmployeeOverTimeShifts(id);
            for(int i = 0; i < st.Count; i++)
            {
                double cost = Math.Floor((st[i].End - st[i].Start).TotalHours) * emp.HourlyPay;
                double overTimeCost = Math.Max(Math.Floor(ot[i] - 8) * 50,0);
                cost += Math.Max(overTimeCost - (Math.Floor(ot[i]-8) * emp.HourlyPay),0);
                Console.WriteLine($"Start:{st[i].Start}\t End:{st[i].End}\t Overtime Duration:{Math.Max(Math.Floor((st[i].End - st[i].Start).TotalHours-8),0)}h \t Cost:{String.Format("{0:0.##}",cost)}$\t OverTimeCost:{String.Format("{0:0.##}", overTimeCost)}$");
                Console.WriteLine("--------------Breaks------------");
                double totalBreakTime = 0;
                foreach(var b in st[i].Breaks)
                {
                    double duration=(b.End - b.Start).TotalMinutes;
                    Console.WriteLine($"\tStart:{b.Start}\t End:{b.End}\t Duration:{String.Format("{0:0.##}", duration)} mins.");
                    totalBreakTime+= duration; 
                }
                Console.WriteLine($"\tTotal Duration:{String.Format("{0:0.##}", totalBreakTime)} mins.");
            }
        }
    }
}