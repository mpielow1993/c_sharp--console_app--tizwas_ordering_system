using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Person
    {
        //PROPERTIES

        //Properties unique to the Product class (and subseqent derivative classes)

        //Properties with non-default values upon initialisation of OrderItem objects
        public string Name { get; set; }
        public string Country { get; set; }
        public Continent Continent { get; set; }

        //CONSTRUCTOR(S)

        public Person(string name, string country, Continent continent)
        {
            Name = name;
            Country = country;
            Continent = continent;
        }
    }   //end class Person
}
