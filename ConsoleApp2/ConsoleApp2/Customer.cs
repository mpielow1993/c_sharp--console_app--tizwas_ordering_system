using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Customer : Person
    {
        //CONSTRUCTOR(S)

        public Customer(string name, string country, Continent continent)
                        : base(name, country, continent)
        { }

        //Overridden ToString method
        public override string ToString()
        {
            return
                $"CustomerName:/t{Name}{Environment.NewLine}" +
                $"Customer Country:\t{Country}{Environment.NewLine}" +
                $"Customer Continent:\t{Continent}{Environment.NewLine}";
        }
    }   //end class Customer
}
