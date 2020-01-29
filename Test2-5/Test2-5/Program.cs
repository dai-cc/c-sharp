using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2_5
{
 //定义IED和IMD接口
    interface IED
    {
        float Length();
        float Width();
    }
    interface IMD
    {
        float Length();
        float Width();
    }
    //从IED和IMD接口派生类Box;
    class Box:IED,IMD
    {
        float lengthInches;
        float widthInches;
        public Box(float length,float width)
        {
            lengthInches = length;
            widthInches = width;
        }

        float IED.Length()
        {
            return lengthInches;
        }
        float IED.Width()
        {
            return widthInches;
        }
        float IMD.Length()
        {
            return lengthInches*2.54f;
        }
        float IMD.Width()
        {
            return widthInches*2.54f;
        }
      
    
    
        static void Main(string[] args)
        {
            //定义一个实类对象"myBox"
            IED myBox1 = new Box(30.0f, 20.0f);
            IMD myBox2 = new Box(30.0f, 20.0f);
            ////定义一个接口"eD"
            //IED eD = (IED)myBox;
            ////定义一个接口"mD"
            //IMD mD = (IMD)myBox;
            //输出
            Console.WriteLine("Length(in):{0}", myBox1.Length());
            Console.WriteLine("Width(in):{0}", myBox1.Width());
            Console.WriteLine("Length(cm):{0}", myBox2.Length());
            Console.WriteLine("length(cm):{0}", myBox2.Width());
            Console.Read();
        }
    }
}

