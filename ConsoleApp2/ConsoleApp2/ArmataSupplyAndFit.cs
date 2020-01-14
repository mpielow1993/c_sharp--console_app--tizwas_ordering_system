using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class ArmataSupplyAndFit : SupplyAndFit
    {
        //CONSTRUCTOR(S)

        public ArmataSupplyAndFit(string name, string code, string description, decimal cost, decimal tax, int orderQuantity)
            : base(name, code, description, cost, tax, orderQuantity)
        {
            //enforce unique constructor conditions for objects of the ArmataSupplyAndFit class

            //name
            if (name != "Supply & Fit - Armata Tank Kit")
            {
                throw new ArgumentException("Name must be 'Supply & Fit - Armata Tank Kit'", "name");
            }
            else
            {
                Name = name;
            }

            //code
            if (code != "S - SF - ATK")
            {
                throw new ArgumentException("Code must be 'S - SF - ATK'", "code");
            }
            else
            {
                Code = code;
            }

            //description
            if (description != "Supply & Fit of an Armata Tank Kit")
            {
                throw new ArgumentException("Description must be 'Supply & Fit of an Armata Tank Kit'", "description");
            }
            else
            {
                Description = description;
            }

            //cost
            if (cost != 7500)
            {
                throw new ArgumentException("Cost must be 7500", "cost");
            }
            else
            {
                Cost = cost;
            }
        }   //end CONSTRUCTOR(S)
    }   //end class ArmataSupplyAndFit
}
