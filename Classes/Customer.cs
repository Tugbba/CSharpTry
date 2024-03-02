using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Customer
    {
        public int Id { get; set; }

      //Eğer ki müşteri ismnini giriyor(set) ve biz ona hitap etmek için isminin başına sözcük eklemek(get) istiyoruz. Bunun için aşağıdaki gibi yazarız.
      //Ama genelde böyle bir kullanım yok eskiden kullanılırdı.
        private string _firstName;
        public string FirstName 
        { 
            get { return "Mr." + _firstName; }
            set { _firstName = value; }
        }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
