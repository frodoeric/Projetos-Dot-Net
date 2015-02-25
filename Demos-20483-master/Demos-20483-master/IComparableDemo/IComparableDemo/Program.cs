using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new ArrayList
            {
                new Person {Name = "Joaquim"},
                new Person {Name = "Manoel"},
                new Person {Name = "Maria"}
            };

            list.Sort();
        }
    }

    class Person : IComparable
    {
        public string Name { get; set; }

        public int CompareTo(object obj)
        {
            // return Less than zero if this object 
            // is less than the object specified by the CompareTo method.

            // return Zero if this object is equal to the object 
            // specified by the CompareTo method.

            // return Greater than zero if this object is greater than 
            // the object specified by the CompareTo method.

            if (obj == null)
            {
                return 1;
            }

            var otherPerson = obj as Person;

            if (otherPerson != null)
            {
                return Name.CompareTo(otherPerson.Name);
            }
            else
            {
                throw new ArgumentException("O objeto não é do tipo Person");
            }
        }
    }
}
