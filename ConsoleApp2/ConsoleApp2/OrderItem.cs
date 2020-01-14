using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public abstract class OrderItem 
    {
        //creation of random object from Random class to help decide indicativeDeliveryTimeInDays (see below)
        Random random = new Random();

        //PROPERTIES 

        //Properties unique to the OrderItem class (and subseqent derivative classes)
        //Properties with non-default values upon initialisation of OrderItem objects (featured in the constructor below)
        public string Name { get; protected set; }
        public string Code { get; protected set; }
        public string Description { get; protected set; }
        public decimal Cost { get; protected set; }
        public decimal Tax { get; protected set; }
        public int OrderQuantity { get; set; }

        //Propeerties with default values upon initialisation of OrderItem objects
        public Continent Continent { get; set; }
        public int IndicativeDeliveryTimeInDays { get; set; }
        public decimal SubTotal { get; set; }
        public decimal GrossTotal { get; set; }
        public decimal NetTotal { get; set; }

        //CONSTRUCTOR(S)

        public OrderItem(string name, string code, string description, decimal cost, decimal tax, int orderQuantity)
        {
            Name = name;
            Code = code;
            Description = description;

            //enforce unique conditions for construction of OrderItem objects

            //cost
            if (cost < 0)
            {
                throw new ArgumentException("Cost cannot be negative", "cost");
            }
            else
            {
                Cost = cost;
            }

            //tax
            if (tax < 0)
            {
                throw new ArgumentException("Tax cannot be negative", "tax");
            }
            else
            {
                Tax = tax;
            }

            //orderQuantity
            if (orderQuantity < 0)
            {
                throw new ArgumentException("orderQuantity cannot be negative", "orderQuantity");
            }
            else
            {
                OrderQuantity = orderQuantity;
            }
        }   //end CONSTRUCTOR(S)

        //METHODS

        //DisplayOrderItem()
        public void DisplayOrderItem()
        {
            ToString();
            Console.WriteLine( $"Sub-Total (total before tax):\t\t\t\t\t\t\t{GetSubTotal():C}{Environment.NewLine}" +
                                $"Gross Total (total after tax and including discount) :\t\t\t\t{GetGrossTotal():C}{Environment.NewLine}" +
                                $"Net Total(including tax-free delivery charge):\t\t\t\t\t{GetNetTotal():C}");
        }

        //Overriden ToString()
        public override string ToString()
        {
            return
                $"\nName:\t\t\t\t\t{Name}{Environment.NewLine}" +
                $"Code:\t\t\t\t\t{Code}{Environment.NewLine}" +
                $"Description:\t\t\t\t{Description}{Environment.NewLine}" +
                $"Cost:\t\t\t\t\t{Cost:C}{Environment.NewLine}" +
                $"Tax:\t\t\t\t\t{String.Format("{0:P2}", Tax)}{Environment.NewLine}" +
                $"OrderQuantity:\t\t\t\t{OrderQuantity}{Environment.NewLine}" +
                $"Indicative Delivery Time (Days):\t{IndicativeDeliveryTimeInDays}{Environment.NewLine}" +
                $"\nSub-Total (total before tax):\t\t\t\t\t\t\t{GetSubTotal():C}{Environment.NewLine}" +
                $"Gross Total (total after tax and including discount):\t\t\t\t{GetGrossTotal():C}{Environment.NewLine}" +
                $"Net Total(including tax-free delivery charge):\t\t\t\t\t{GetNetTotal():C}{Environment.NewLine}";
        }

        //abstract methods of OrderItem
        public abstract decimal GetNetTotal();
        public abstract decimal GetGrossTotal();
        public abstract decimal GetSubTotal();
        public abstract void GetDeliveryDetails();
    }   //end abstract class OrderItem
}
