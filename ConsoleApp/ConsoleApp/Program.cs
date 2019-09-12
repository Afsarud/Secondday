using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //This is fiest assignment of 10-09-2019
            int age;
            string name, address, contact;
            Console.WriteLine("Enter your name please:");
            name = Console.ReadLine();

            Console.WriteLine("Enter Your Age please:");
            age = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter Your Contact Number");
            contact = Console.ReadLine();

            Console.WriteLine("Enter Your Address");
            address = Console.ReadLine();
            Console.WriteLine(name +", "+ age + ", " +contact +", "+address);

            Console.ReadKey();
        }
    }
}
