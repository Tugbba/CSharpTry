using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Database database = new Oracle();
            database.Add();
            database.Delete();

            Database database2 = new SqlServer();
            database2.Add();
            database2.Delete();

            Console.ReadLine();

        }
    }


    //Diyelim ki Add bütün veri tabanlarında aynı fakat Delete veri tabanlarında farklı farklı olsun.
    //Bu yüzden Add normal method halinde yazarız . Fakat Deleteyi abstract halinde yazarız.
    //Database yi de hiçbir zaman newleyemeyiz bize uyarı verir onun yerine database içindeki oracle ve sqlserveri newleriz.

    abstract class Database
    {
        public void Add()
        {
            Console.WriteLine("Added by default ");
        }

        public abstract void Delete();
    }

    class SqlServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by  Sql");
        }
    }

    class Oracle : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Oracle");
        }
    }

}
// interfaceler gibi absractları da newleyemeyiz. Classları newleyebiliriz.
