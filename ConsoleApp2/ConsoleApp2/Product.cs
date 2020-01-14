using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Product : OrderItem
    {
        //PROPERTIES 

        //Properties unique to the Product class (and subseqent derivative classes)
        //Properties with default values upon initialisation of OrderItem objects
        public decimal DeliveryCharge { get; protected set; }

        //CONSTRUCTOR(S)

        public Product(string name, string code, string description, decimal cost, decimal tax, int orderQuantity)
               : base(name, code, description, cost, tax, orderQuantity)
        {
            //enforce unique constructor conditions for objects of the Product class

            //tax
            if (tax != 0.125M)
            {
                throw new ArgumentException("Tax for products is 12.5% written as a decimal (i.e 0.125M)", "tax");
            }
            else
            {
                Tax = tax;
            }

        }   //end CONSTRUCTOR(S)

        //METHODS

        //Overridden GetNetTotal() method specific to products
        public override decimal GetNetTotal()
        {
            NetTotal = GrossTotal + DeliveryCharge;
            return NetTotal;
        }

        //Overridden GetGrossTotal() method specific to products
        public override decimal GetGrossTotal()
        {
            GrossTotal += SubTotal * (1 + Tax);
            return GrossTotal;
        }

        //Overridden GetSubTotal() method specific to products
        public override decimal GetSubTotal()
        {
            SubTotal += OrderQuantity * Cost;
            return SubTotal;
        }

        // Method GetDeliveryDetails() for the Product class (dependent on Continent)
        //Continent value is currently defaulted to NULL, will be set to the Recipient Continent in the CompleteOrder class
        public override void GetDeliveryDetails()
        {
            Random random = new Random();

            switch ((int)Continent)
            {
                case 1:
                    IndicativeDeliveryTimeInDays = random.Next(2, 11);
                    break;
                case 2:
                    IndicativeDeliveryTimeInDays = random.Next(4, 22);
                    break;
                case 3:
                    IndicativeDeliveryTimeInDays = random.Next(4, 26);
                    break;
                case 4:
                    IndicativeDeliveryTimeInDays = random.Next(5, 31);
                    break;
                case 5:
                    IndicativeDeliveryTimeInDays = random.Next(3, 15);
                    break;
            }   //end switch
        }   //end GetDeliveryDetails()

        //Overridden ToString() method
        public override string ToString()
        {
            return
            base.ToString() +
            $"\nDelivery Charge:\t\t\t\t\t\t\t\t{DeliveryCharge:C}{Environment.NewLine}";
        }
    }   //end class Product
}
