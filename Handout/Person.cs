using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handout
{
    internal class Person
    {
        private string name;
        private string age;



        public Person(string name, string age)
        {
            this.name = name;
            this.age = age;
        }

        public Person() 
        {
            name = "Undefined";
            age = "NotKnown";
        }

        public string Name
        {

            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Age
        {
            get { return age; }
            set { age = value; }
        }
    }
}