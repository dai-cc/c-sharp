using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp2
{
    class Class2
    {
        static void Main(string[] args)
        {
            double sum = 0.5, t, t1,t2, t3, p = 0.5 * 0.5;
            int odd = 1, even = 2;
            t = t1 = t2 = 1.0;
            while (t > 1e-10) {
                t1 = t1 * odd / even;
                odd += 2;
                even += 2;
                t2 = 1.0 / odd;
            }
        }
    }
}
