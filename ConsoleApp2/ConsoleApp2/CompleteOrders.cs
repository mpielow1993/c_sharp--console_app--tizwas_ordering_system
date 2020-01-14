using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class CompleteOrders : ICollection<CompleteOrder>
    {
        //Create empty list to store completed Live Orders

        List<CompleteOrder> CompleteOrderList = new List<CompleteOrder>();

        //ICollection<CompleteOrder> mandatory implementation
        public int Count
        {
            get
            {
                return CompleteOrderList.Count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public void Add(CompleteOrder item)
        {
            CompleteOrderList.Add(item);
        }

        public void Clear()
        {
            CompleteOrderList.Clear();
        }

        public bool Contains(CompleteOrder item)
        {
            return CompleteOrderList.Contains(item);
        }

        public void CopyTo(CompleteOrder[] array, int arrayIndex)
        {
            CompleteOrderList.CopyTo(array, arrayIndex);
        }

        public IEnumerator<CompleteOrder> GetEnumerator()
        {
            return CompleteOrderList.GetEnumerator();
        }

        public bool Remove(CompleteOrder item)
        {
            return CompleteOrderList.Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return CompleteOrderList.GetEnumerator();
        }

        //Implement unique functionality for the CompleteOrders class
       
        //Display all Live and CancelledOrders

        //method DisplayAllLiveOrders()
        public static void DisplayAll(CompleteOrders CompleteOrderList)
        {
            foreach (CompleteOrder CompleteOrder in CompleteOrderList)
            {
                CompleteOrder.DisplayCompleteOrder();
            }
        }

        //As you remove a complete order from the LiveOrders list, it must go to the CancelledOrders list
        //A Cancelled order may also need to be reinstated to Live again
        //This is done via unique method RemoveCompletedOrder()      
        
        //Static method RemoveCompletedOrder() will allow a single completed order to be removed from
        //one list and transferred to another and back again (e.g. from LiveOrders to CancelledOrders).
        public static void RemoveAndTransfer(CompleteOrder completeOrder, CompleteOrders ListTransferredFrom, CompleteOrders ListTransferredTo)
        {
            //exception thrown if the order to be removed is not in the list it is being transferred from
            if (ListTransferredFrom.Contains(completeOrder) == false)
            {
                throw new ArgumentException("This completed order is not currently in the list you are transferring FROM");
            }

            //Complete Order removed from current list and transferred to new list (denoted as ListTransferredTo)
            else
            {
                ListTransferredFrom.Remove(completeOrder);
                ListTransferredTo.Add(completeOrder);
            }
        }   //end RemoveAndTransfer()
    }   //end class CompleteOrders
}

