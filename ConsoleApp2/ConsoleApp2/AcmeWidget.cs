using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class AcmeWidget : Product
    {

        //PROPERTIES

        //properties unique to the AcmeWidget class (and subseqent derivative classes)
        //properties with default values upon initialisation of AcmeWidget objects (featured in the constructor below)
        public decimal Discount { get; private set; }

        //CONSTRUCTOR(S)

        public AcmeWidget(string name, string code, string description, decimal cost, decimal tax, int orderQuantity)
                    : base(name, code, description, cost, tax, orderQuantity)
        {
            //enforce constructor conditions

            //name
            if (name != "Acme Widget")
            {
                throw new ArgumentException("Name must be 'AcmeWidget'", "name");
            }
            else
            {
                Name = name;
            }

            //code
            if (code != "P - AW")
            {
                throw new ArgumentException("Code must be 'P - AW'", "code");
            }
            else
            {
                Code = code;
            }

            //description
            if (description != "Useful thing-a-majig")
            {
                throw new ArgumentException("Description must be 'Useful thing-a-majig'", "description");
            }
            else
            {
                Description = description;
            }

            //cost
            if (cost != 55.95M)
            {
                throw new ArgumentException("Cost must be 55.95M", "cost");
            }
            else
            {
                Cost = cost;
            }

            //orderQuantity
            if (orderQuantity % 7 != 0)
            {
                throw new ArgumentException($"Order Quantity for {Name} must be a multiple of 7", "orderQuantity");
            }
            else
            {
                OrderQuantity = orderQuantity;
            }

            //discount (dependent on orderQuantity)
            if (OrderQuantity >= 28)
            {
                Discount = 0.1M;
            }
            else
            {
                Discount = 0;
            }

        }   //END CONSTRUCTOR(S)

        //METHODS

        //GetDeliveryDetails method for Acme Widget class (dependent on Continent)
        //Continent value is currently defaulted to NULL, will be set to the Recipient Continent in the CompleteOrder class
        public override void GetDeliveryDetails()
        {
            Random random = new Random();

            switch ((int)Continent)
            {
                case 1:
                    IndicativeDeliveryTimeInDays = random.Next(2, 11);
                    DeliveryCharge = 1.25M;     //delivery charges are tax free
                    break;
                case 2:
                    IndicativeDeliveryTimeInDays = random.Next(4, 22);
                    DeliveryCharge = 2.5M;
                    break;
                case 3:
                    IndicativeDeliveryTimeInDays = random.Next(4, 26);
                    DeliveryCharge = 4;
                    break;
                case 4:
                    IndicativeDeliveryTimeInDays = random.Next(5, 31);
                    DeliveryCharge = 4.75M;
                    break;
                case 5:
                    IndicativeDeliveryTimeInDays = random.Next(3, 15);
                    DeliveryCharge = 3.50M;
                    break;
            }   //end switch
        }   //end GetDeliveryDetails()

        //overridden GetGrossTotal() method to account for the discount specific to Acme Widgets
        public override decimal GetGrossTotal()
        {
            GrossTotal += SubTotal * (1 + Tax - Discount);
            return GrossTotal;
        }

        //Overridden ToString() method
        public override string ToString()
        {
            return base.ToString() +
            $"Discount:\t\t\t\t\t\t\t\t\t{String.Format("{0:P2}", Discount)}{Environment.NewLine}";
        }
    }   //end class AcmeWidget
}
