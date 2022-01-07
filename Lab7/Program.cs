using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            double a1 = Convert.ToDouble(Console.ReadLine());
            double b1 = Convert.ToDouble(Console.ReadLine());
            double c1 = Convert.ToDouble(Console.ReadLine());
            double a2 = Convert.ToDouble(Console.ReadLine());
            double b2 = Convert.ToDouble(Console.ReadLine());
            double c2 = Convert.ToDouble(Console.ReadLine());
            double S1, S2;
            Geron(a1, b1, c1, out S1);
            Geron(a2, b2, c2, out S2);
            if (S1>S2)
            {
                Console.WriteLine("Площадь 1-ого больше");
            }
            else
            {
                Console.WriteLine("Площадь 2-ого больше");
            }
            Console.ReadKey();
        }
        static void Geron(double x, double y, double z, out double Summ)
        {
            Summ = Math.Sqrt(((x + y + z) / 2) * (((x + y + z) / 2) - x) * (((x + y + z) / 2) - y) * (((x + y + z) / 2) - z));
        }
    }
}
