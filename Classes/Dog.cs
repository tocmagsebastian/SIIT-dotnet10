using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Dog
    {
        // Attributes //

        // Fields: keep the state of the class //
        private string name;
        private string breed;

        // Constructors //
        public Dog() // parameterless constructor
        {
            name = "Undefined";
            breed = "NotKnown";
        }

        public Dog(string name, string breed) // Constructor with parameters
        {
            this.name = name;
            this.breed = breed;
        }

        // Properties //

        // public string Name { get; set; } // autmoatic property

        public string Name
        {
            // getter
            get 
            { 
                return name; 
            }
            // setter
            set 
            {
                name = value; 
            }
        }

        public string Breed 
        { 
            get 
            {
                return breed;
            }
            set
            {
                breed = value;
            }

        }

        // Behavior //

    }
}
