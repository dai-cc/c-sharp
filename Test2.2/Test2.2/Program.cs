using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2._2
{
    class Program
    {
        static void Main(string[] args) {
            Console.Write("请输入圆的半径：");
            string s = Console.ReadLine();
            double r = Convert.ToDouble(s);
            double square = PI() * r * r;
            Console.WriteLine("圆的面积是{0,10:f8}", square);
            Console.Read();
        }
        static double PI()
        {
            //计算PI的值 直到所加项小于1e-10为止
            double sum = 0.5, t, t1, t2, t3, p = 0.25;
            int odd = 1, even = 2;
            t = t1 = t2 = 1.0;
            t3 = 0.5;
            do
            {
                t1 = t1 * odd / even;
                odd += 2;
                even += 2;
                t2 = 1.0 / odd;
                t3 = t3 * p;
                t = t1 * t2 * t3;
                sum += t;
            } while (t > 1e-10);
            return sum * 6;
        }
    }
}
