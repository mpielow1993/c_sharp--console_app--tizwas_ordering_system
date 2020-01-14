using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Recipient : Person
    {
        //Properties unique to the Recipient class (and subseqent derivative classes)

        //Properties with non-default values upon initialisation of OrderItem objects
        public string Address { get; set; }

        //CONSTRUCTOR(S)

        public Recipient(string name, string address, string country, Continent continent)
                : base(name, country, continent)
        {
            Address = address;
        }

        //overridden ToString() method
        public override string ToString()
        {
            return
                $"Recipient Name:/t{Name}{Environment.NewLine}" +
                $"Recipient Country:\t{Country}{Environment.NewLine}" +
                $"Recipient Address:\t{Address}{Environment.NewLine}" +
                $"\nRecipient Continent:\t{Continent}";
        }
    }   //end class Recipient
}
