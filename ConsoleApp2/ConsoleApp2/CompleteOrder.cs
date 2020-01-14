using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class CompleteOrder : ICollection<OrderItem>
    {
        //PROPERTIES

        //Properties unique to the CompleteOrder class
        
        //Properties with default values upon initialisation of OrderItem objects
        public string OrderID { get; set; }
        public string OrderCreationDate { get; set; }
        public List<OrderItem> RequestedItems { get; set; }
        
        //Properties with non-default values upon initialisation of OrderItem objects
        public Customer CustomerDetails { get; set; }
        public Recipient DestinationDetails { get; set; }

        //CONSTRUCTOR(S)

        public CompleteOrder(string customerName, string customerCountry, Continent customerContinent,
                            string recipientName, string recipientAddress, string recipientCountry, Continent recipientContinent)
        {
            CustomerDetails = new Customer(customerName, customerCountry, customerContinent);
            DestinationDetails = new Recipient(recipientName, recipientAddress, recipientCountry, recipientContinent);
            RequestedItems = new List<OrderItem>();
        }   //end CONSTRUCTOR(S)

        //ICollection<OrderItem> mandatory implementation

        public int Count
        {
            get
            {
                return RequestedItems.Count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public void Add(OrderItem item)
        {
            RequestedItems.Add(item);
        }

        public void Clear()
        {
            RequestedItems.Clear();
        }

        public bool Contains(OrderItem item)
        {
            return RequestedItems.Contains(item);
        }

        public void CopyTo(OrderItem[] array, int arrayIndex)
        {
            RequestedItems.CopyTo(array, arrayIndex);
        }

        public IEnumerator<OrderItem> GetEnumerator()
        {
            return RequestedItems.GetEnumerator();
        }

        public bool Remove(OrderItem item)
        {
            return RequestedItems.Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return RequestedItems.GetEnumerator();
        }

        //Unique functionality for CompleteOrder class

        //method DisplayCompleteOrder()
        public void DisplayCompleteOrder()
        {
            Console.Write($"\n\nCOMPLETED ORDER\n\n" +
                            $"\nOrderId:\t\t{GetOrderID()}{Environment.NewLine}" +
                            $"\nOrder Creation Date:\t{GetOrderCreationDate()}\n");
            DisplayPersonalDetails();
            DisplayRequestedItems();
        }

        //method GetOrderID()
        public string GetOrderID()
        {
            OrderID = Guid.NewGuid().ToString();
            return 
                OrderID.ToString();
        }

        //method GetOrderCreationDate()
        public string GetOrderCreationDate()
        {
            OrderCreationDate = DateTime.Today.ToString("d");
            return
                OrderCreationDate;
        }

        //method DisplayPersonalDetails()
        public void DisplayPersonalDetails()
        {
            Console.WriteLine($"\nPERSONAL DETAILS{Environment.NewLine}" +
                                $"\nCustomer Name:\t\t{CustomerDetails.Name}{Environment.NewLine}" +
                                $"Customer Country:\t{CustomerDetails.Country}{Environment.NewLine}" +
                                $"Customer Continent:\t{CustomerDetails.Continent}{Environment.NewLine}" +
                                $"\nRecipient Name:\t\t{DestinationDetails.Name}{Environment.NewLine}" +
                                $"Recipient Address:\t{DestinationDetails.Address}{Environment.NewLine}" +
                                $"Recipient Country:\t{DestinationDetails.Country}{Environment.NewLine}" +
                                $"Recipient Continent:\t{DestinationDetails.Continent}{Environment.NewLine}");
        }

        //method DisplayRequestedItems()
        public void DisplayRequestedItems()
        {

            //initial values

            Console.WriteLine("\nREQUESTED ITEMS\n");

            decimal FinalSubTotal = 0;
            decimal FinalGrossTotal = 0;
            decimal FinalNetTotal = 0;
            int listNumber = 0;
            int ExpectedDeliveryTimeInDays = int.MinValue;

            if (RequestedItems.Count == 0)
            {
                throw new ArgumentException("Requested Items list for this order is empty");
            }
            else
            {
                foreach (OrderItem RequestedItem in RequestedItems)
                {
                    //The polymorphism implemented in the GetSubTotal(), GetGrossTotal(), GetNetTotal() and GetDeliveryDetails() methods
                    //will output the results according to the conditions set for each derivative class
                    
                    //GetSubTotal()
                    RequestedItem.GetSubTotal();
                    FinalSubTotal += RequestedItem.SubTotal;

                    //GetGrossTotal()
                    RequestedItem.GetGrossTotal();
                    FinalGrossTotal += RequestedItem.GrossTotal;

                    //GetNetTotal();
                    RequestedItem.GetNetTotal();
                    FinalNetTotal += RequestedItem.NetTotal;

                    //Increment the list number
                    ++listNumber;
                    Console.WriteLine($"{listNumber}.");

                    //Set the default value of Requested Item.Continent for each Requested Item 
                    //to the value of the Recipient Continent
                    RequestedItem.Continent = DestinationDetails.Continent;

                    //Retrieve each Requested Item's Delivery Details according to the above value for Continent
                    RequestedItem.GetDeliveryDetails();

                    //determines the maximum of all delivery times of the Requested Items and sets the maximum as the overall expected delivery time
                    if (RequestedItem.IndicativeDeliveryTimeInDays > ExpectedDeliveryTimeInDays)
                    {
                        ExpectedDeliveryTimeInDays = RequestedItem.IndicativeDeliveryTimeInDays;
                    }

                    //Display each Requested Item
                    Console.WriteLine(RequestedItem.ToString());
                }
            }
            Console.WriteLine("\nTOTAL\n");
            Console.Write($"Expected Delivery Time (Days):\t\t{ExpectedDeliveryTimeInDays}{Environment.NewLine}" +
                            $"\nFinal Sub Total:\t\t\t{FinalSubTotal:C}{Environment.NewLine}" +
                            $"\nFinal Gross Total:\t\t\t{FinalGrossTotal:C}{Environment.NewLine}" +
                            $"\nFinal Net Total:\t\t\t{FinalNetTotal:C}{Environment.NewLine}");
        }   //end DisplayRequestedItems()
    }   //end class CompleteOrder
}
