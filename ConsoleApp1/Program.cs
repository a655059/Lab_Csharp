using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello C#!");
            Console.Write("enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name);
            Console.ReadKey();
        }
    }
}
