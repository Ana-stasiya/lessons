using lessons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessons
{

    class ThreeD
    {
        int x, y, z;
        public ThreeD()
        {
            x = y = z = 0;
        }
        public ThreeD(int i, int j, int k)
        {
            x = i; y = j; z = k;
        }

        public static ThreeD operator + (ThreeD op1, ThreeD op2)
        {
            ThreeD result = new ThreeD();
            result.x = op1.x + op2.x;
            return result;
        }
        public void Show()
        {
            Console.WriteLine(x + ", " + y + ", " + z);
        }

    }
    
}

//static void Main(string[] args)
//{
//    ThreeD a = new ThreeD(1, 2, 3);
//    ThreeD b = new ThreeD(10, 10, 30);
//    ThreeD c;
//    c = a + b;
//    c.Show();
//}