namespace Boxind_and_Unboxing_Challenge
{
    public class OrderProcessorV3
    {
        private readonly Dictionary<int, OrderStatus> _orderCache = new();
        private readonly List<int> _pendingOrders = new();

        public enum OrderStatus { Pending, Processing, Completed }

        public void AddOrder(int orderId, OrderStatus status)
        {
            _orderCache.Add(orderId, status);
            _pendingOrders.Add(orderId);
        }

        public string GetSummary(int orderId, decimal amount, DateTime date)
            => $"Order {orderId} ${amount} on {date:yyyyy-MM-dd}";

        public bool IsCompleted(OrderStatus status)
            => status == OrderStatus.Completed;

        public bool TryGetStatus(int orderId, out OrderStatus status)
            => _orderCache.TryGetValue(orderId, out status);
    }
}
