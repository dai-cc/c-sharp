using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //卡布列克运算 任意一个四位数 只要他们各个位上的数字不相同就有如下规律：
            //把组成这个数字的四个数从大到小排列，形成有这四个数字组成的最大四位数
            //最小四位数
            //求相减结果   应为6174
            Console.Write("请输入一个4位整数");
            string[] str = Console.ReadLine().Split(' ');
            //string s = Console.ReadLine();//存储读入的四位数
            //int num = Convert.ToInt32(s);//将字符转化为整形
            try
            {
                int num = (Convert.ToInt32(str[0]) * 1000) + (Convert.ToInt32(str[1]) * 100) + (Convert.ToInt32(str[2]) * 10) + Convert.ToInt32(str[3]);
                int[] each = new int[4];//each数组
                int max, min, i, j, temp;
                //判断字符串中字符是否全是数字，不全是则不继续执行
                while (num != 6174 && num != 0)
                {
                    i = 0;
                    while (num != 0)
                    {
                        each[i++] = num % 10;
                        num = num / 10;
                    }
                    //从小到大排序
                    for (i = 0; i < 3; i++)
                    {
                        for (j = 0; j < 3 - i; j++)
                        {
                            if (each[j] > each[j + 1])
                            {
                                temp = each[j];
                                each[j] = each[j + 1];
                                each[j + 1] = temp;
                            }
                        }
                    }

                    min = (each[0] * 1000) + (each[1] * 100) + (each[2] * 10) + each[3];
                    max = (each[3] * 1000) + (each[2] * 100) + (each[1] * 10) + each[0];
                    num = max - min;
                    Console.WriteLine("{0}-{1}={2}", max, min, num);
                }
            }
            catch(System.IndexOutOfRangeException) {
                Console.Write("输入有误！");
            }
          
        }
    }
}
