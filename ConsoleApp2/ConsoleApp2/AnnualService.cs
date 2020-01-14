using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class AnnualService : Service
    {
        //PROPERTIES

        //properties unique to the Annual Service class (and subseqent derivative classes)
        //properties with default values upon initialisation of Annual Service objects
        public decimal PartsAndLabourCost { get; set; }

        //CONSTRUCTOR(S)

        public AnnualService(string name, string code, string description, decimal cost, decimal tax, int orderQuantity)
            : base(name, code, description, cost, tax, orderQuantity)
        {
            //enforce conditions for construction of Annual Service object

            //name
            if (name != "Annual Service - Armata Tank Kit")
            {
                throw new ArgumentException("Name must be 'Annual Service - Armata Tank Kit'", "name");
            }
            else
            {
                Name = name;
            }

            //code
            if (code != "S - AS - ATK")
            {
                throw new ArgumentException("Code must be 'S - AS - ATK'", "name");
            }
            else
            {
                Code = code;
            }


            //description
            if (description != "Annual Servicing of Armata Tank Kits")
            {
                throw new ArgumentException("Description must be 'Annual Servicing of Armata Tank Kits'", "description");
            }
            else
            {
                Description = description;
            }

            //cost
            if (cost != 1200)
            {
                throw new ArgumentException("Cost must be 1200", "cost");
            }
            else
            {
                Cost = cost;
            }

        }   //END CONSTRUCTOR(S)

        //METHODS

        //overriden GetSubTotal() method to account for Parts & Labour Cost specific to AnnualService class
        public override decimal GetSubTotal()
        {
            SubTotal = (OrderQuantity * Cost) + PartsAndLabourCost;
            return SubTotal;
        }

        //method GetPartsAndLabourCost()
        public decimal GetPartsAndLabourCost()
        {
            Console.WriteLine("\nFor an Annual Service, a Parts And Labour Cost is also incurred with the Fitting Cost." +
             "\nThis is calculated by the number of hours worked mulitiplied by the current labour rate, plus the cost of parts." +
             "\nPlease input these below:");

            Console.WriteLine("\nNumber of Hours Worked:");
            decimal noOfHours = decimal.Parse(Console.ReadLine());

            Console.WriteLine("\nCurrent rate of labour:");
            decimal currentRate = decimal.Parse(Console.ReadLine());

            Console.WriteLine("\nCost of parts:");
            decimal costOfParts = decimal.Parse(Console.ReadLine());

            PartsAndLabourCost = (noOfHours) * (currentRate) + costOfParts;

            Console.WriteLine($"\nParts & Labour Cost for this Annual Service product updated to {PartsAndLabourCost:C}");

            return 
                PartsAndLabourCost;
        }
        
        //Overridden ToString() method
        public override string ToString()
        {
            return
                base.ToString() +
                $"Parts and Labour Cost:\t\t\t\t\t\t\t\t{PartsAndLabourCost:C}{Environment.NewLine}";
        }
    }   //end class AnnualService
}
