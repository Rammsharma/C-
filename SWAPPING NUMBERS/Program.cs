
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SwaptwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int NUM1, NUM2, TEMP;
            Console.Write("ENTER FIRST NUMBER :");
            NUM1 =int.Parse(Console.ReadLine());
            Console.Write("ENTER SECOND NUMBER :");
            NUM2 =int.Parse(Console.ReadLine());

            TEMP = NUM1;
            NUM1 = NUM2;
            NUM2 = TEMP;

            Console.WriteLine("After Swaping:-");
            Console.WriteLine("FIRST NUMBER = " + NUM1);
            Console.WriteLine("SECOND NUMBER = " + NUM2);
            Console.ReadLine();
        }
    }
}