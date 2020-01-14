using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class AcmeSupplyAndFit : SupplyAndFit
    {
        //CONSTRUCTOR(S)

        public AcmeSupplyAndFit(string name, string code, string description, decimal cost, decimal tax, int orderQuantity)
            : base(name, code, description, cost, tax, orderQuantity)
        {
            //enforce unique constructor conditions for objects of the ArmataSupplyAndFit class

            //name
            if (name != "Supply & Fit - Acme Widget")
            {
                throw new ArgumentException("Name must be 'Supply & Fit - Acme Widget'", "name");
            }
            else
            {
                Name = name;
            }

            //code
            if (code != "S - SF - AW")
            {
                throw new ArgumentException("Code must be 'S - SF - AW'", "code");
            }
            else
            {
                Code = code;
            }

            //description
            if (description != "Supply & Fit of an Acme Widget")
            {
                throw new ArgumentException("Description must be 'Supply & Fit of an Acme Widget'", "description");
            }
            else
            {
                Description = description;
            }

            //cost
            if (cost != 15.25M)
            {
                throw new ArgumentException("Cost must be 15.25 written as a decimal (15.25M)", "cost");
            }
            else
            {
                Cost = cost;
            }
        }   //end CONSTRUCTOR(S)
    }   //end class AcmeSupplyAndFit
}
