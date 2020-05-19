using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation_lab
{
    class Person
    {
        
        public Person(string firstname, string lastname, int age)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.age = age;
        }

        private string firstname;
        private string lastname;
        private int age;

        public string Firstname
        {
            get
            {
                return this.firstname;
            }
        }

        public string Lastname
        {
            get
            {
                return this.lastname;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
        }

        public override string ToString()
        {
            return $"{this.firstname}  {this.lastname} is {this.age} years old";
        }
    }
}
