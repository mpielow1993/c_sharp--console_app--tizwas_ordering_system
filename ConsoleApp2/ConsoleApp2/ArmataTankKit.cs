using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class ArmataTankKit : Product
    {
        //PROPERTIES

        //Properties unique to the ArmataTankKit class (and subseqent derivative classes)
        //Properties with default values upon initialisation of ArmataTankKit objects
        public decimal Discount { get; private set; }

        //CONSTRUCTOR(S)

        public ArmataTankKit(string name, string code, string description, decimal cost, decimal tax, int orderQuantity)
                            : base(name, code, description, cost, tax, orderQuantity)
        {
            //enforce constructor conditions

            //name
            if (name != "Armata Tank Kit")
            {
                throw new ArgumentException("Name must be 'Armata Tank Kit'", "name");
            }
            else
            {
                Name = name;
            }

            //code
            if (code != "P - ATK")
            {
                throw new ArgumentException("Code must be 'P - ATK'", "code");
            }
            else
            {
                Code = code;
            }

            //description
            if (description != "Assembly Kit for Weapon of Mass Destruction")
            {
                throw new ArgumentException("Description must be 'Assembly Kit for Weapon of Mass Destruction'", "description");
            }
            else
            {
                Description = description;
            }

            //cost
            if (cost != 3200000)
            {
                throw new ArgumentException("Cost must be 3200000", "cost");
            }
            else
            {
                Cost = cost;
            }

            //orderQuantity
            if (orderQuantity % 1 != 0)
            {
                throw new ArgumentException($"Order Quantity for {Name} must be a multiple of 1", "orderQuantity");
            }
            else
            {
                OrderQuantity = orderQuantity;
            }

            //discount (dependent on orderQuantity)
            if (orderQuantity >= 5)
            {
                Discount = 0.15M;
            }
            else
            {
                Discount = 0;
            }
        }   //END CONSTRUCTOR(S)

        //METHODS

        //GetDeliveryDetails method for ArmataTankKit class (which is dependent on Continent)
        //Continent value is currently defaulted to NULL, will be set to the Recipient Continent in the CompleteOrder class
        public override void GetDeliveryDetails()
        {
            Random random = new Random();

            switch ((int)Continent)
            {
                case 1:
                    IndicativeDeliveryTimeInDays = random.Next(2, 11);
                    DeliveryCharge = 475;   //delivery charges are tax free
                    break;
                case 2:
                    IndicativeDeliveryTimeInDays = random.Next(4, 22);
                    DeliveryCharge = 700;
                    break;
                case 3:
                    IndicativeDeliveryTimeInDays = random.Next(4, 26);
                    DeliveryCharge = 900;
                    break;
                case 4:
                    throw new ArgumentException("Armata Tank Kit does NOT deliver to Oceania", "continent");
                case 5:
                    throw new ArgumentException("Armata Tank Kit does NOT deliver to The Americas", "continent");
            }   //end switch
        }   //end GetDeliveryDetails()

        //Overriden GetGrossTotal() method to account for the discount specific to Armata Tank Kits
        public override decimal GetGrossTotal()
        {
            GrossTotal = SubTotal * (1 + Tax - Discount);
            return GrossTotal;
        }

        //Overridden ToString() method
        public override string ToString()
        {
            return base.ToString() +
            $"\nDiscount:\t\t\t\t\t\t\t\t\t{String.Format("{0:P2}", Discount)}{Environment.NewLine}";
        }
    }   //end class ArmataTankKit
}
