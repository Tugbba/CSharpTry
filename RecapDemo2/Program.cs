using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo2  // SENARYO: müşterimiz loglamadan haberdar olmak için birçok farklı yoldan ona bildirmemizi istedi diyelim ki .
                      // 1-Database yolu ile 2-File şeklinde 3-Sms ile .
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Logger = new DatabaseLogger();   // müşterimiz databaseye değil de sms yolu ile loglamayı öğrenmek isterse buraya new SmsLogger(); yazarız.
            customerManager.Add();

            Console.ReadLine();
        }
    }

    class CustomerManager
    {
        public ILogger Logger { get; set; }
        public void Add()
        {
            Logger.Log();
            Console.WriteLine("Customer added!");
        }
    }

    interface ILogger
    {
        void Log();
    }

    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database!");
        }
    }

    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to file!");
        }
    }

    //Böylelikle loglamayı nereden öğrenmek isterse müşterimiz,o platformu kolaylıkla yazılımımıza eklemiş oluruz. 

    //class SmsLogger : ILogger
    //{
    //    public void Log()
    //    {
    //        Console.WriteLine("Logged to sms!");
    //    }
    //}

   

    
}
