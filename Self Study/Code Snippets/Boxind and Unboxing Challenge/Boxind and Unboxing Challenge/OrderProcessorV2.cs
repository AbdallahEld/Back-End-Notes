namespace Boxind_and_Unboxing_Challenge
{
    public class OrderProcessorV2
    {
        // What we fixed:
        // 1. Replaced Hashtable with Dictionary<int, OrderStatus> to avoid boxing and unboxing of value types.
        // 2. Replaced ArrayList with List<int> to store pending orders, which is more type-safe and efficient.
        // 3. Updated the PrintSummary method to use string interpolation for better readability.
        // 4. Updated the IsCompleted method to take an OrderStatus parameter instead of object, eliminating the need for boxing and unboxing.
        private Dictionary<int, OrderStatus> _orderCache = new Dictionary<int, OrderStatus>();
        private List<int> _pendingOrders = new List<int>();
        public enum OrderStatus { Pending, Processing, Completed }
        public void AddOrder(int orderId, OrderStatus status)
        {
            _orderCache.Add(orderId, status);
            _pendingOrders.Add(orderId);
        }
        public void PrintSummary(int orderId, decimal amount, DateTime date)
        {
            Console.WriteLine($"Order {orderId}: ${amount} on {date}");
        }

        public bool IsCompleted(OrderStatus status)
        {
            return status == OrderStatus.Completed;
        }
        // Other Possible Improvements:
        // It doesnt make sense to use console.writeline cause imagine our application is a web app or desktop app,
        // we can return the string instead of printing it directly, so we can use it in different contexts.
        public string PrintSummaryV2(int orderId, decimal amount, DateTime date)
        {
            return $"Order {orderId}: ${amount} on {date}";
        }
        public void PrintSummaryV3(int orderId, decimal amount, DateTime date, Span<char> buffer)
        {
            int pos = 0; // Position in the buffer

            "Order ".AsSpan().CopyTo(buffer[pos..]); // Turn the string into a span and copy it to the buffer
            pos += 6; // Move the position forward by the length of the string

            orderId.TryFormat(buffer[pos..], out int written); // Try to format the orderId into the buffer and get the number of characters written
            pos += written; // Move the position forward by the number of characters written

            ": $".AsSpan().CopyTo(buffer[pos..]);
            pos += 3;

            amount.TryFormat(buffer[pos..], out written);
            pos += written;

            " on ".AsSpan().CopyTo(buffer[pos..]);
            pos += 4;

            date.TryFormat(buffer[pos..], out written);
        }
    }
}
