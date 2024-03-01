using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string student1 = "Engin";
            //string student2 = "Derin";
            //string student3 = "Salih";
            //Böyle tek tek yazmak yerine aynı veri tiplerine sahip olanları array içinde kullanırız.

            //string[] students = new string[3];
            //students[0] = "Engin";
            //students[1] = "Derin";
            //students[2] = "Salih";     Bu şekilde de array yazılır.

            string[] students = new string[3] { "Engin", "Derin", "Salih" }; //Bu şekilde de array yazılır.

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            //Çok boyutlu dizilere de örnek verelim.

            string[,] regions = new string[4, 3] 
            {
                { "istanbul","izmit","balıkesir" },
                { "ankara","konya","kırıkkale" },
                { "antalya","adana","mersin" },
                { "izmir","muğla","manisa" }

            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
                Console.WriteLine("*****"); // Böyle yazarak bölgeleri birbirinden ayırmış oldum.
            }

            Console.ReadLine();
        }
    }
}
