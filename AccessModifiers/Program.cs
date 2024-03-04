using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class Customer : Student
    {     // private ile yazarsak id, tanımlandığı class içindeki tüm metotlarda kullanılır.
          //public ile yazarsak id sadece yazıldığı metotta kullanılır.
        private int Id { get; set; }
        public void Save()
        {
            Id 
            Id1
        }
        public void Delete()
        {

        }
    }

    //protected ile yazarsak ise id sadece tanımlandığı classta değil diğer classlarda da çağırılabilir
    //fakat şu ayrıntıyı unutmamalıyız: hangi classta tanımladıysan id yi ve hangi classta da olsun istiyosan
    //gidip tanımladığın classı çağırmak istediğin classa inheritance gibi yaz.
    class Student
    {
        protected int Id1 { get; set; }
        public void Save2()
        {
           
            
        }
    }

    //Neden internal ekledik classımızın başına.Çünkü diyelim ki bizim projemizin adı AccessModifiers değil mi
    //biz bu proje içinde add-new proje-class diyip bir CourseManager classı oluşturduk.
    //yeni açtığımız classın(CourseManager) içine de Course classını çağırıcaz bunu direkt olarak çağırabilmemizi yani direkt newlememize izin verir.
    //Yani kısaca internal eklediğimizde istediğimiz an istediğimiz yerde çağırabileceğimiz anlamına gelir.
    internal class Course
    {
        public string Name { get; set; }
    }
}
 
     //internal sadece o proje içinde her yerde kullanılacağı anlamına geliyordu.PUBLİC ise diğer tüm projelerde de kullanılabilir anlamına gelir.
     //Başka projede kullanmak istediğimizde ise kullanacağımız projenin referancesine gelip hangi projeyi kullanmak istediğini seçmelisin.
     //Sonrasında da içinde kullanmak istediğimiz projeye gelip en başına- USİNG KULLANMAK İSTEDİĞİMİZ PROJE İSMİ;-yaz.

