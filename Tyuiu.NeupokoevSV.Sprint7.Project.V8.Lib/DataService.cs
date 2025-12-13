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
    }
}