using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input number:A,and press Enter.");
            string txtA = Console.ReadLine();


            Console.WriteLine("Please input number:B,and press Enter.");
            string txtB = Console.ReadLine();
            int A = Convert.ToInt32(txtA);
            int B = Convert.ToInt32(txtB);
            Console.WriteLine("A is" + A);


            int c = A + B;
            //int a = 40;
            //int b = 50;
            //int c = a + b;

            //Console.WriteLine("c"is);
            //Console.WriteLine(c.ToString("0000"));

            //Console.WriteLine("a:" + a + "+b:" + b+"="+c);
            //Console.WriteLine(string.Format("{0}+{1}={2}",a,b,c));
            //Console.WriteLine(string.Format($"{a}+{b}+{c}"));

            Console.ReadLine();
        }


    }
}
