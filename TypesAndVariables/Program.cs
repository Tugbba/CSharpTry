using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Value Types
            //Console.WriteLine("Hello World!");
            double number5 = 10.2;
            decimal number6 = 10.4397m;
            char character = 'A';
            bool condition = false;
            byte number4 = 1;
            short number3 = -372;
            int number1 = 10;
            long number2 = 214748;
            var number7 = 111;
            Console.WriteLine("Number1 is {0}",number1);
            Console.WriteLine("Number2 is {0}", number2);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number4 is {0}", number4);
            Console.WriteLine("Character is : {0}", character);
            Console.WriteLine("Number5 is {0}", number5);
            Console.WriteLine("Number6 is {0}", number6);
            Console.WriteLine("Number7 is {0}", number7);
            Console.WriteLine(Days.Friday);
            Console.ReadLine();
        }
    }

    enum Days
    {
        Monday,Tuesday,Wednesday,Thursday,Friday,Saturday
    }
}
