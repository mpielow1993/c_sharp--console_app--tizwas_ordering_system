using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {       
            //Instantiate 5 objects from the derivative classes of the OrderItem class (conditions attached)

            AcmeWidget acmeWidget1 = new AcmeWidget("Acme Widget", "P - AW", "Useful thing-a-majig", 55.95M, 0.125M, 7);
            AcmeWidget acmeWidget2 = new AcmeWidget("Acme Widget", "P - AW", "Useful thing-a-majig", 55.95M, 0.125M, 21);
            AcmeWidget acmeWidget3 = new AcmeWidget("Acme Widget", "P - AW", "Useful thing-a-majig", 55.95M, 0.125M, 28);
            AcmeWidget acmeWidget4 = new AcmeWidget("Acme Widget", "P - AW", "Useful thing-a-majig", 55.95M, 0.125M, 35);
            AcmeWidget acmeWidget5 = new AcmeWidget("Acme Widget", "P - AW", "Useful thing-a-majig", 55.95M, 0.125M, 14);

            ArmataTankKit armataTankKit1 = new ArmataTankKit("Armata Tank Kit", "P - ATK", "Assembly Kit for Weapon of Mass Destruction", 3200000, 0.125M, 1);
            ArmataTankKit armataTankKit2 = new ArmataTankKit("Armata Tank Kit", "P - ATK", "Assembly Kit for Weapon of Mass Destruction", 3200000, 0.125M, 3);
            ArmataTankKit armataTankKit3 = new ArmataTankKit("Armata Tank Kit", "P - ATK", "Assembly Kit for Weapon of Mass Destruction", 3200000, 0.125M, 5);
            ArmataTankKit armataTankKit4 = new ArmataTankKit("Armata Tank Kit", "P - ATK", "Assembly Kit for Weapon of Mass Destruction", 3200000, 0.125M, 4);
            ArmataTankKit armataTankKit5 = new ArmataTankKit("Armata Tank Kit", "P - ATK", "Assembly Kit for Weapon of Mass Destruction", 3200000, 0.125M, 2);

            DuffBeer duffBeer1 = new DuffBeer("Duff Beer", "P - DB", "Homer Simpson's favourite beverage", 2.75M, 0.125M, 4);
            DuffBeer duffBeer2 = new DuffBeer("Duff Beer", "P - DB", "Homer Simpson's favourite beverage", 2.75M, 0.125M, 2);
            DuffBeer duffBeer3 = new DuffBeer("Duff Beer", "P - DB", "Homer Simpson's favourite beverage", 2.75M, 0.125M, 10);
            DuffBeer duffBeer4 = new DuffBeer("Duff Beer", "P - DB", "Homer Simpson's favourite beverage", 2.75M, 0.125M, 8);
            DuffBeer duffBeer5 = new DuffBeer("Duff Beer", "P - DB", "Homer Simpson's favourite beverage", 2.75M, 0.125M, 6);

            AcmeSupplyAndFit acmeSupplyAndFit1 = new AcmeSupplyAndFit("Supply & Fit - Acme Widget", "S - SF - AW", "Supply & Fit of an Acme Widget", 15.25M, 0.0925M, 3);
            AcmeSupplyAndFit acmeSupplyAndFit2 = new AcmeSupplyAndFit("Supply & Fit - Acme Widget", "S - SF - AW", "Supply & Fit of an Acme Widget", 15.25M, 0.0925M, 4);
            AcmeSupplyAndFit acmeSupplyAndFit3 = new AcmeSupplyAndFit("Supply & Fit - Acme Widget", "S - SF - AW", "Supply & Fit of an Acme Widget", 15.25M, 0.0925M, 2);
            AcmeSupplyAndFit acmeSupplyAndFit4 = new AcmeSupplyAndFit("Supply & Fit - Acme Widget", "S - SF - AW", "Supply & Fit of an Acme Widget", 15.25M, 0.0925M, 5);
            AcmeSupplyAndFit acmeSupplyAndFit5 = new AcmeSupplyAndFit("Supply & Fit - Acme Widget", "S - SF - AW", "Supply & Fit of an Acme Widget", 15.25M, 0.0925M, 1);

            ArmataSupplyAndFit armataSupplyAndFit1 = new ArmataSupplyAndFit("Supply & Fit - Armata Tank Kit", "S - SF - ATK", "Supply & Fit of an Armata Tank Kit", 7500, 0.0925M, 1);
            ArmataSupplyAndFit armataSupplyAndFit2 = new ArmataSupplyAndFit("Supply & Fit - Armata Tank Kit", "S - SF - ATK", "Supply & Fit of an Armata Tank Kit", 7500, 0.0925M, 4);
            ArmataSupplyAndFit armataSupplyAndFit3 = new ArmataSupplyAndFit("Supply & Fit - Armata Tank Kit", "S - SF - ATK", "Supply & Fit of an Armata Tank Kit", 7500, 0.0925M, 3);
            ArmataSupplyAndFit armataSupplyAndFit4 = new ArmataSupplyAndFit("Supply & Fit - Armata Tank Kit", "S - SF - ATK", "Supply & Fit of an Armata Tank Kit", 7500, 0.0925M, 5);
            ArmataSupplyAndFit armataSupplyAndFit5 = new ArmataSupplyAndFit("Supply & Fit - Armata Tank Kit", "S - SF - ATK", "Supply & Fit of an Armata Tank Kit", 7500, 0.0925M, 2);

            AnnualService annualService1 = new AnnualService("Annual Service - Armata Tank Kit", "S - AS - ATK", "Annual Servicing of Armata Tank Kits", 1200, 0.0925M, 3);
            AnnualService annualService2 = new AnnualService("Annual Service - Armata Tank Kit", "S - AS - ATK", "Annual Servicing of Armata Tank Kits", 1200, 0.0925M, 5);
            AnnualService annualService3 = new AnnualService("Annual Service - Armata Tank Kit", "S - AS - ATK", "Annual Servicing of Armata Tank Kits", 1200, 0.0925M, 2);
            AnnualService annualService4 = new AnnualService("Annual Service - Armata Tank Kit", "S - AS - ATK", "Annual Servicing of Armata Tank Kits", 1200, 0.0925M, 1);
            AnnualService annualService5 = new AnnualService("Annual Service - Armata Tank Kit", "S - AS - ATK", "Annual Servicing of Armata Tank Kits", 1200, 0.0925M, 4);


            //Instantiate 5 CompleteOrder objects

            CompleteOrder completeOrder1 = new CompleteOrder("John McDoe", "Ireland", Continent.Europe,
                                                             "Joe van der Bloeggs", "123 Fake Street, Hillbrow, Johannesburg, J08URG", "South Africa", Continent.Africa);
            CompleteOrder completeOrder2 = new CompleteOrder("Donald Trump", "USA", Continent.The_Americas,
                                                            "Theresa May", "10 Downing Street, London, SW1A 2AA", "United Kingdom", Continent.Europe);
            CompleteOrder completeOrder3 = new CompleteOrder("Steve Irwin", "Australia", Continent.Oceania,
                                                            "Kim Jong Un", "Ryongsong Residence, Pyongyang, D34R L34D3R", "North Korea", Continent.Asia);
            CompleteOrder completeOrder4 = new CompleteOrder("John Jameson", "Ireland", Continent.Europe,
                                                            "Jack Daniels", "7 Sour Mash Road, Lynchburg, Tennessee", "USA", Continent.The_Americas);
            CompleteOrder completeOrder5 = new CompleteOrder("Robert Mugabe","Zimbabwe", Continent.Africa,
                                                            "Frodo Baggins", "The Shire, Hobbiton, North Island", "New Zealand", Continent.Oceania);

            //Add 5 OrderItem objects to each CompleteOrder (conditions and functionality demonstrated below)
            
            //N.B****Certain features are purposefully indented with a '*' to aid program flow
            //Please undo in order to see the their effects****

            //completeOrder1
            completeOrder1.Add(acmeWidget2);
            completeOrder1.Add(armataTankKit4);
            completeOrder1.Add(duffBeer3);

            //Methods AddJobNotes(), RemoveJobNotes() and DisplayJobNotes() 
            //allow notes for SupplyAndFit objects to be updated at any time

            //Example
            
            //*acmeSupplyAndFit5.AddJobNotes();
            //*acmeSupplyAndFit5.RemoveJobNotes();
            //*acmeSupplyAndFit5.DisplayJobNotes();

            completeOrder1.Add(acmeSupplyAndFit5);
            completeOrder1.Add(armataSupplyAndFit1);

            //Method GetPartsAndLabourCost() calculates the cost of parts and labour (determined by the user)
            //and adds it to the Sub-Total of this Requested Item

            //*annualService2.GetPartsAndLabourCost();
            completeOrder1.Add(annualService2);

            //Method DisplayCompleteOrder() outputs the complete order (see CompleteOrder class for details)

            //*completeOrder1.DisplayCompleteOrder();

            //Now add the rest of the OrderItem objects to the RequestedItems lists of the rest of the CompleteOrder objects

            //completeOrder2
            completeOrder2.Add(acmeWidget5);
            completeOrder2.Add(armataTankKit1);
            completeOrder2.Add(duffBeer4);
            completeOrder2.Add(acmeSupplyAndFit3);
            completeOrder2.Add(armataSupplyAndFit2);
            completeOrder2.Add(annualService5);

            //completeOrder3
            completeOrder3.Add(acmeWidget3);
            completeOrder3.Add(armataTankKit5);
            completeOrder3.Add(duffBeer1);
            completeOrder3.Add(acmeSupplyAndFit2);
            completeOrder3.Add(armataSupplyAndFit4);
            completeOrder3.Add(annualService3);

            //completeOrder4
            completeOrder4.Add(acmeWidget4);

            //If the following ArmataTankKit OrderItem is added to the following CompleteOrder item,
            //an exception will be thrown (as the Recipient Continent is The_Americas)

            //*completeOrder4.Add(armataTankKit3);

            completeOrder4.Add(duffBeer5);
            completeOrder4.Add(acmeSupplyAndFit1);
            completeOrder4.Add(armataSupplyAndFit5);
            completeOrder4.Add(annualService4);

            //completeOrder5
            completeOrder5.Add(acmeWidget1);

            //If the following ArmataTankKit OrderItem is added to the following CompleteOrder item,
            //an exception will be thrown (as the Recipient Continent is Oceania)

            //*completeOrder5.Add(armataTankKit2);

            completeOrder5.Add(duffBeer2);
            completeOrder5.Add(acmeSupplyAndFit4);
            completeOrder5.Add(armataSupplyAndFit3);
            completeOrder5.Add(annualService1);

            //Add orders to instantiated object LiveOrders of the class CompleteOrders

            CompleteOrders LiveOrders = new CompleteOrders();

            LiveOrders.Add(completeOrder1);
            LiveOrders.Add(completeOrder2);
            LiveOrders.Add(completeOrder3);
            LiveOrders.Add(completeOrder4);
            LiveOrders.Add(completeOrder5);

            //CancelledOrders object

            CompleteOrders CancelledOrders = new CompleteOrders();

            //Here, static method RemoveAndTransfer() removes a single Complete Order from the LiveOrders List
            //and transfer it to the CancelledOrders List
            CompleteOrders.RemoveAndTransfer(completeOrder1, LiveOrders, CancelledOrders);

            //Static method DisplayAll() displays all complete orders from the selected list
            //CompleteOrders.DisplayAll(CancelledOrders);
            CompleteOrders.DisplayAll(LiveOrders);

            Console.ReadKey();
        }
    }
}
