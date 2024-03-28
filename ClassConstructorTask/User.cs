using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassConstructorTask
{
    internal class User
    {
        public string Name;
        public string Surname;
        public string Password;
        public byte Age;

        public User(string name,string surname,string password,byte age)
        {
            Name = name;
            Surname = surname;
            Password = password;
            Age = age;
        }
        public bool IsPasswordValid()
        {
            if (Password.Length < 6 || Password.Contains(Name, StringComparison.OrdinalIgnoreCase) || !IsCheckDigit())
            {
                return false;
            }
            return true;
        }
       
        public bool IsCheckDigit()
        {
            foreach (char ch in Password)
            {                                      
                if (char.IsDigit(ch))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
