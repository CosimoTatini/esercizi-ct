using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"a ={b},b={a}");
            (a,b) = (b,a);
            Console.WriteLine($"a={b}, b={a}");
            int c= Convert.ToInt32(Console.ReadLine());


        }
    }
}


