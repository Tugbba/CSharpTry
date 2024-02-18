using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Add();
            Add();
            Add();
            Add();
           var result = Add2(20, 30);
            Console.WriteLine(result);
            Console.WriteLine(Multiply(4,5));
            Console.WriteLine(Multiply(3,4,5));
           Console.WriteLine(Add3(1,2,3,4,5,6));
            Console.ReadLine();
        }
        static void Add()
        {
            Console.WriteLine("Added!");
        }   
        // Bir metodu çağırırken yap et diyorsak void kullanırız.
        // Bir metodu aritmetik işlemlerde kullanıyorsak void değil int yazarız.
        static int Add2(int number1, int number2)
        {
            var result = number1 + number2;
            return result;
        }

        static int Multiply(int number3,int number4)
        {
            return number3 * number4;
        }

        static int Multiply(int number3, int number4, int number5)
        {
            return number3 * number4 * number5;
        }

        // İkiden üçten fazla sayılarla işlem yapmka istersek params kullanırız.

        static int Add3(params int[] numbers)
        {
            return numbers.Sum();
        }

    }

}
