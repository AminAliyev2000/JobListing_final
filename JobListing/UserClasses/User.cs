using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobListing
{
    abstract class Users
    {
        public int Id { get; set; }
        public static int StaticId { get; set; } = 0;
        public string Name { get; set; } = "";
        public string Surname { get; set; } = "";
        public int Age { get; set; } = 0;
        public string PhoneNum { get; set; } = "";
        public string Place { get; set; }
        public string Email { get; set; }
        public string Username { get; set; } = "";
        public string Password { get; set; } = "";

        public Users()
        {
            Id = ++StaticId;
        }
        public override string ToString()
        {
            return $"\n====================================================================================================\n" +
                $"Id:{Id}\nName:{Name}\nSurname:{Surname}\nAge:{Age}\nTelephone:{PhoneNum}\nUsername:{Username}\nPassword:{Password}";
        }
    }
    
}
