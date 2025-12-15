using Tyuiu.NeupokoevSV.Sprint7.Project.V8.Lib;
namespace Tyuiu.NeupokoevSV.Sprint7.Project.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void SredStaj()
        {
            DataService ds = new DataService();
            var drivers = new List<DataService.Driver>
            {
                new DataService.Driver { Experience = 5 },
                new DataService.Driver { Experience = 3 }
            };
            double res = ds.SredStaj(drivers);
            double wait = 4.0;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void SredOkl()
        {
            DataService ds = new DataService();
            var drivers = new List<DataService.Driver>
            {
                new DataService.Driver { Salary = 50000 },
                new DataService.Driver { Salary = 30000 }
            };

            decimal res = ds.SredOkl(drivers);

            decimal wait = 40000;
            Assert.AreEqual(wait, res);
        }
    }
}