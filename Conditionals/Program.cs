using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = 11;
            if (number == 10)
            {
                Console.WriteLine("Number is 10");
            }
            else if (number == 20) 
            {
                Console.WriteLine("Number is 20");
            }
            else 
            {
               Console.WriteLine("Number is not 10 or 20");
            }    

            switch (number)
            {
                case 10:
                    Console.WriteLine("Number is 10");
                    break;
                case 20:
                    Console.WriteLine("Number is 20");
                    break;
                default:
                    Console.WriteLine("Number is not 10 or 20");
                    break;
            }
            // if else şart bloğunu birde switch ile nasıl yapılır bunu öğrenmiş oldum.

            // Aşağıda bir pratik yaptım.

            var number1 = 200;
            if (number1 >= 0 && number1 <= 100)
            {
                Console.WriteLine("Number1 is between 0-100");
            }
            else if (number1>100 && number1 <= 200)
            {
                Console.WriteLine("Number1 is between 101-200");
            }
            else if (number1>200 || number1 < 0)
            {
                Console.WriteLine("Number1 is less than 0 or greater than 101-200");
            }

            Console.ReadLine();

        }
    }
}
