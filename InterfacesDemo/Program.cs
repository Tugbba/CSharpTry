using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{

    // bir şirket var ve 3 tip çalışanı olsun : yönetici,çalışan,robot. Hepsi çalışır, hepsi yemek yemez ve maaş almaz.O yüzden birden fazla interface tanımladık ,
    // interfacelere bu özellikleri verdik.
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
               new Manager(),
               new Worker(),
               new Robot(),
            };

            foreach (var worker in workers)
            {
                worker.Work(); 
            }

            IEat[] eats = new IEat[2]
            {
                new Manager(),
                new Worker(),
            };

            foreach (var eat in eats)
            {
                eat.Eat();
            }

            ISalary[] salarys = new ISalary[2]
            {
                new Manager(),
                new Worker(),
            };
           
            
        }
    }

    interface IWorker
    {
        void Work();

    }
    interface IEat
    {
        void Eat();
    }

    interface ISalary
    {
        void GetSalary();
    }

    //bir class birden fazla interfaceye sahip olabilir.
    class Manager : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine();
        }

        public void GetSalary()
        {
            Console.WriteLine();
        }

        public void Work()
        {
            Console.WriteLine();
        }
    }
    class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine();
        }

        public void GetSalary()
        {
            Console.WriteLine();
        }

        public void Work()
        {
            Console.WriteLine();
        }
    }

    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine();
        }
    }
}
