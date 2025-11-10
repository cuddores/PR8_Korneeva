using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace сon5_КорнееваАС
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car truck1 = new Car();
            truck1.mark = "Nissan"; truck1.model = "Skyline R34"; truck1.year = 2002;
            truck1.mileage = 85000;
            truck1.ShowInfo();

            Car truck2 = new Car("Toyota", "Supra MK4", 1998, 120000);
            truck2.ShowInfo();
        }
    }

    class Car
    {
        public string mark;
        public string model;
        public int year;
        public double mileage;

        public Car() { }
        public Car(string mar, string mod, int yr, double mil)
        {
            this.mark = mar;
            this.model = mod;
            this.year = yr;
            this.mileage = mil;
        }
        public void ShowInfo()
        {
            int currentYear = DateTime.Now.Year;

            Console.WriteLine("Автомобиль: {0} {1}, {2} года выпуска, пробег: {3} км, возрастом {4}", mark, model, year, mileage, currentYear - year);
        }
    }
}
