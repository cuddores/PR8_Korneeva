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
            build dom1 = new build();
            dom1.name = "Дача"; dom1.area = 30; dom1.kvo = 4; dom1.floor = 9;
            dom1.ShowInfo();

            build dom2 = new build("Коттедж", 80, 6, 3);
            dom2.ShowInfo();
        }
    }

    class build
    {
        public string name;
        public double area;
        public int kvo;
        public int floor;

        public build() { }
        public build(string nm, double ar, int k, int f)
        {
            this.name = nm;
            this.area = ar;
            this.kvo = k;
            this.floor = f;
        }
        public void ShowInfo()
        {
            Console.WriteLine("В доме {0} площадью {1} на {2} этаже, живет {3} чел, на человека {4:f2}", name, area, floor, kvo, area / kvo);
        }
    }
}
