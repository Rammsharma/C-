using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumEvenOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.Write("Enter a number :  ");
            i= int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.Write("entered number is even");
                Console.Read();
            }
            else
            {
                Console.WriteLine("entered number is odd");
                Console.Read();
            }

            
        }
    }
}
