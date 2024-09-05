using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcv2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            char op;
            Console.Write("enter number 1 = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("enter number 2 = ");
            b = int.Parse(Console.ReadLine());
            Console.Write("enter operator = ");
            op = char.Parse(Console.ReadLine());

            if (op == '+')
            {
                Console.WriteLine("Answer = " + (a + b));
            }
            else if(op == '-')
            {
                Console.WriteLine("Answer = " + (a - b));
            }
            else if(op == '*')
            {
                Console.WriteLine("Answer = " + (a * b));
            }
            else if(op == '/')
            {
                Console.WriteLine("Answer = " + (a / b));
            }

        }
    }
}
