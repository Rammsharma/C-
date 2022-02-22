using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace InputPrint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Name;
            string Course;
            int Age;

            Console.Write("Enter your Name : ");
            Name = Console.ReadLine();
            Console.Write("Enter your Course : ");
            Course = Console.ReadLine();
            Console.Write("Enter your Age : ");
            Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("MY NAME = "+Name);
            Console.WriteLine();
            Console.Write("MY COURSE =" + Course);
            Console.WriteLine();
            Console.Write("MY AGE =" + Age);
            Console.ReadLine();
        }
    }
}