using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Service : OrderItem
    {
        //CONSTRUCTOR(S)

        public Service(string name, string code, string description, decimal cost, decimal tax, int orderQuantity)
                : base(name, code, description, cost, tax, orderQuantity)
        {
            //enforce unique constructor conditions for objects of the Service class

            //tax
            if (tax != 0.0925M)
            {
                throw new ArgumentException("Tax for services is 9.25% written as a decimal (0.0925M)", "tax");
            }
            else
            {
                Tax = tax;
            }

        }   //END CONSTRUCTOR(S)

        //METHODS

        //GetDeliveryDetails() method for the Service class
        public override void GetDeliveryDetails()
        {
            Random random = new Random();

            //IndicativeDeliveryTimeInDays for services (dependent on Continent)
            //Continent value is currently defaulted to NULL, will be set to the Recipient Continent in the CompleteOrder class
            switch ((int)Continent)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    IndicativeDeliveryTimeInDays = random.Next(1, 9);
                    //services do not have any specified delivery charge
                    break;
            }   //end switch
        }   //end GetDeliveryDetails()

        //Overridden GetNetTotal method common to all services
        public override decimal GetNetTotal()
        {
            NetTotal =  GrossTotal;
            return NetTotal;
        }

        //Overridden GetGrossTotal() method common to all services
        public override decimal GetGrossTotal()
        {
            GrossTotal += SubTotal * (1 + Tax);
            return GrossTotal;
        }

        //Overridden GetSubTotal() method common to all services
        public override decimal GetSubTotal()
        {
            SubTotal += OrderQuantity * Cost;
            return SubTotal;
        }
    }   //end class Service
}
