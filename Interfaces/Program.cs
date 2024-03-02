using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();

            //Demo();

            
            ICustomerDal[] customerDals = new ICustomerDal[2]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal(),
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

            //verimizi hem sqlserver veri tabanına hemde oracle veri tabanında görmek istersek yukarıdaki şekilde yazarız.
            
            Console.ReadLine();
        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager();
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Tuğba",
                LastName = "Cinbek",
                Address = "Ankara"
            };

            Student student = new Student
            {
                Id = 1,
                FirstName = "Serkan",
                LastName = "Sağlam",
                Departmant = "Computer Sciences"
            };
            manager.Add(customer);
            manager.Add(student);
        }
    }

    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }
    class Customer : IPerson //IPerson da tanımlanmış her şey artık Class Customerde de gözükücek demek
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }
    class Student : IPerson  //IPerson da tanımlanmış her şey artık Class Studentte de gözükücek demek
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);

        }
    }

}



//interfaceler newlenmez, classlar newlenir.*******