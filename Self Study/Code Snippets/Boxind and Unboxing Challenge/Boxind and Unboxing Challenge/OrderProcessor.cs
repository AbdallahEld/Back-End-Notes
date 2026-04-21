using System.Collections;

namespace Boxind_and_Unboxing_Challenge
{
    // This class is designed to process orders and manage their statuses.
    // It uses a Hashtable to store order IDs and their corresponding statuses, and an ArrayList to keep track of pending orders.
    // The AddOrder method allows adding new orders with their statuses, while the PrintSummary method formats a summary of an order.
    // The IsCompleted method checks if a given status is equal to the Completed status.
    // Note: There is a problem here a lot of boxing and unboxing is happening, which can lead to performance issues.
    public class OrderProcessor
    {
        private Hashtable _orderCache = new Hashtable();
        private ArrayList _pendingOrders = new ArrayList();

        public enum OrderStatus { Pending, Processing, Completed}

        public void AddOrder(int orderId, OrderStatus status)
        {
            _orderCache.Add(orderId, status);
            _pendingOrders.Add(orderId);
        }

        public void PrintSummary(int orderId, decimal amount, DateTime date)
        {
            string.Format("Order {0}: ${1} on {2}", orderId, amount, date);
        }

        public bool IsCompleted(object status)
        {
            return status.Equals(OrderStatus.Completed);
        }
    }
}
