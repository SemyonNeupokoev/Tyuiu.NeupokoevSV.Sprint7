using System;

namespace Tyuiu.NeupokoevSV.Sprint7.Project.V8.Lib
{
    public class DataService
    {
        public class Driver
        {
            public string TabNumber { get; set; } = "";
            public string LastName { get; set; } = "";
            public string FirstName { get; set; } = "";
            public string MiddleName { get; set; } = "";
            public DateTime BirthDate { get; set; } = DateTime.Now;
            public int Experience { get; set; } = 0;
            public decimal Salary { get; set; } = 0;
        }
        public double SredStaj(List<Driver> drivers)
        {
            if (drivers == null || drivers.Count == 0)
                return 0;

            int total = 0;
            foreach (var d in drivers)
                total += d.Experience;

            return Math.Round((double)total / drivers.Count, 2);
        }
        public  decimal SredOkl(List<Driver> drivers)
        {
            if (drivers == null || drivers.Count == 0)
                return 0;

            decimal total = 0;
            foreach (var d in drivers)
                total += d.Salary;

            return Math.Round(total / drivers.Count, 2);
        }
    }
}