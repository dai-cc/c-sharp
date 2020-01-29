using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2_4
{
    class CRect
    {
        private int top, botton, left, right;
        public static int total_rects = 0;
        public static long total_rect_area = 0;

        public CRect()
        {
            left = top = right = botton = 0;
            total_rects++;//3
            total_rect_area += getHeight() * getWidth();//10
            Console.WriteLine("CReact() Contructing rectangle number{0}", total_rects);//3
            Console.WriteLine("Total rectangle ares is:{0}", total_rect_area);//10
        }

        public CRect(int x1,int y1,int x2,int y2)//1 3 6 4
        {
            left = x1;//1
            top = y1;//3
            right = x2;//6
            botton = y2;//4
            total_rects++;//1
            total_rect_area += getHeight() * getWidth();//0+1*5
            Console.WriteLine("CRect(int, int, int, int)Contructing rectangle number{0}", total_rects);//1
            Console.WriteLine("Total rectangle area is:{0}",total_rect_area);//5
        }

        public CRect(CRect r)//rect1
        {
            left = r.left;//1
            right = r.right;//6
            top = r.top;//3
            botton = r.botton;//4
            total_rects++;//2
            total_rect_area += getHeight() * getWidth();//5+1*5==10
            Console.WriteLine("CRect(CRect&)Contructing retangle number{0}", total_rects);//2
            Console.WriteLine("Total rectangle area is:{0}", total_rect_area);//10
        }
        public int getHeight()
        { 
            return top >botton?top-botton:botton-top;
        }
        public int getWidth()
        {
            return right > left ? right - left : left - right; 
        }
        public static int getTotalRects()
        {
            return total_rects; 
        }
        public static long getTotalRectArea()
        {
            return total_rect_area; 
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            CRect rect1 = new CRect(1,3,6,4), rect2 = new CRect(rect1);
            Console.Write("Rectangle2:Height:{0}", rect2.getHeight());//1
            Console.WriteLine(",Width:{0}", rect2.getWidth());//5
            //{ //注释1
                CRect rect3 = new CRect();
                Console.Write("Rectangle3:Height:{0}", rect3.getHeight());//0
                Console.WriteLine(",Width:{0}", rect3.getWidth());//0
           // }//注释2
            Console.Write("total_rects={0},",CRect.total_rects);//3
            Console.WriteLine("total_rect_area:{0}", CRect.total_rect_area);//10
            Console.Read();
        }
    }
}
