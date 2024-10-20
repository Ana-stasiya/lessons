using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessons
{
    internal class refandout
    {
        public void sqr(ref int i)
        {
            i = i * i;
        }

        public int gp(double n, out double frac)
        {
            int whole;
            whole = (int)n;
            frac = n - whole;
            return whole;
        }
    }
}

//Main
//     refandout ro = new refandout();
//int a = 10;
//int b = 20;
//Console.WriteLine("а до вызова " + a);
//ro.sqr(ref a);
//Console.WriteLine("а после вызова " + a);

//refandout or = new refandout();
//int i;
//double f;
//i = or.gp(10.125, out f);
//Console.WriteLine("целая часть " + i);
//Console.WriteLine("дробная часть " + f);
