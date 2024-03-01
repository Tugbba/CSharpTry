using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = "Ankara";
            // Console.WriteLine(city[0]);   BU ANKARA'NIN İLK HARFİ OLAN A YI YAZDIR DEMEK
            //foreach ile ankara kelimesinin tüm harflerini alt alta yazdık.
            //Intro(city);

            //sentencenin uzunluğunu söylemesi için sentence.Length yaazdık.
            string sentence = "My name is Engin Demiroğ";

            var result = sentence.Length;

            bool result2 = sentence.EndsWith("ğ");   // cümle ğ ile bitiyor mu?
            bool result3 = sentence.StartsWith("My name");   // cümle My name ile başlıyor mu?
            var result4 = sentence.IndexOf("name");  // cümle içinde name var ise kaçıncı karakterden sonra yazılmış bunu ekrana yazar.
            var result5 = sentence.Insert(0, "Hello, ");  // cümlenin başına hello, eklettik
            var result6 = sentence.Substring(3); // cümlenin başını kesti ,ilk 3 karakteri yok etti.
            var result10 = sentence.Remove(2);  // cümlenin ilk 2 karakterinden sonrasını yok etti
            var result7 = sentence.ToLower();  // cümledeki tüm karakterleri küçük harfe çevirir.
            var result8 = sentence.ToUpper();  //cümledeki tüm karakterleri büyük harfe çevirir.
            var result9 = sentence.Replace(" ", "-");  // cümledeki boşluk olan yerlere - koy demek.
            Console.WriteLine(result10);

            Console.ReadLine();
        }

        private static void Intro(string city)
        {
            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            //ankara ile istanbul'u yan yana yazdırmış olduk.
            string city2 = "Istanbul";
            string result = city + city2;
            Console.WriteLine(result);
        }
    }
}
