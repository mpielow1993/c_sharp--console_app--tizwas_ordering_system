using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class DuffBeer : Product
    {       
        //CONSTRUCTOR(S)

        public DuffBeer(string name, string code, string description, decimal cost, decimal tax, int orderQuantity)
                : base(name, code, description, cost, tax, orderQuantity)
        {
            //enforce constructor conditions

            //name
            if (name != "Duff Beer")
            {
                throw new ArgumentException("Name must be 'Duff Beer'", "name");
            }
            else
            {
                Name = name;
            }

            //code
            if (code != "P - DB")
            {
                throw new ArgumentException("Code must be 'P - DB'", "code");
            }
            else
            {
                Code = code;
            }

            //description
            if (description != "Homer Simpson's favourite beverage")
            {
                throw new ArgumentException("Description must be 'Homer Simpson's favourite beverage'", "description");
            }
            else
            {
                Description = description;
            }

            //cost
            if (cost != 2.75M)
            {
                throw new ArgumentException("Cost must be 2.75 written as a decimal (2.75M)", "cost");
            }
            else
            {
                Cost = cost;
            }

            //orderQuantity
            if (orderQuantity % 2 != 0)
            {
                throw new ArgumentException($"Order Quantity for {Name} must be a multiple of 2", "orderQuantity");
            }
            else
            {
                OrderQuantity = orderQuantity;
            }

        }   //END CONSTRUCTOR(S)

        //METHODS

        //GetDeliveryDetails method for Duff Beer class (dependent on Continent)
        //Continent value is currently defaulted to NULL, will be set to the Recipient Continent in the CompleteOrder class
        public override void GetDeliveryDetails()
        {
            Random random = new Random();

            switch ((int)Continent)
            {
                case 1:
                    IndicativeDeliveryTimeInDays = random.Next(2, 11);
                    DeliveryCharge = 0.55M; //delivery charges are tax free
                    break;
                case 2:
                    IndicativeDeliveryTimeInDays = random.Next(4, 22);
                    DeliveryCharge = 1.25M;
                    break;
                case 3:
                    IndicativeDeliveryTimeInDays = random.Next(4, 26);
                    DeliveryCharge = 1.55M;
                    break;
                case 4:
                    IndicativeDeliveryTimeInDays = random.Next(5, 31);
                    DeliveryCharge = 2;
                    break;
                case 5:
                    IndicativeDeliveryTimeInDays = random.Next(3, 15);
                    DeliveryCharge = 1.45M;
                    break;
            }   //end switch
        }   //end GetDeliveryDetails()
    }   //end class DuffBeer
}
