using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a,z,b,y,x;
            a = Convert.ToDouble(Console.ReadLine());
            z = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            if (z < a  * b) 
            {
               x=Math.Sqrt(a * a + b * b * z);
            }
            else {
                x=Math.Sin(z * z) + Math.Abs(a * b *z);
            }
            y = (Math.Cos(Math.Sqrt(x))*x*b+x*a)/x+a*b;
            Console.WriteLine(y);
            Console.ReadLine(); 
        }
    }   
}