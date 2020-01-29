using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp2
{
    class Class1
    {
        static void Main2(string[] args)
        {

            //猜四色球放置情况 红黄黑白分别放置在1 2 3 4 盒子中
            //甲 黑球c在1 黄球b在2
            //乙 黑球c在2 白球d在3
            //丙 红球a在2 白球d在4
            //甲乙丙个猜对一半

            int a = 1;//分别代表红 黄 黑 白四个球
            int b = 1;
            int c = 1;
            int d = 1;
            while (a <= 4)
            {
                b = 1;
                while (b <= 4)
                {
                    c = 1;
                    while (c <= 4)
                    {
                      
                        if (a != b && b != c && a != c)
                        { //排除掉abc值相同的情况
                            d = 10 - a - b - c;
                            //甲乙丙各猜对一半，所以他们对应语句异或结果为true  当满足&&在一起的结果为true对应结果则为正确答案
                            if ((c == 1 ^ b == 2) && (c == 2 ^ d == 3) && (a == 2 ^ d == 4))
                            {
                                Console.Write("红球放在{0}号箱,黄球放在{1}号箱", a,b);
                                Console.WriteLine("黑球放在{0}号箱,白球放在{0}号箱", c,d);
                            }
                        }
                        c++;
                    }
                    b++;
                }
                a++;
            }
            Console.Read();      
        }
    }
}
        
