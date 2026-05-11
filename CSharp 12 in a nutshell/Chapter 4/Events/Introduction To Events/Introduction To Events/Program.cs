namespace Introduction_To_Events
{
    internal class Program
    {
        static void stock_PriceChanged(object sender, PriceChangedEventArgs e)
        {
            if (e.LastPrice == 0) return;

            if ((e.NewPrice - e.LastPrice) / e.LastPrice > 0.1M)
                Console.WriteLine("Alert! 10% price increase!");
        }
        public delegate void PriceChangedHandler(decimal oldPrice, decimal newPrice);
        static void Main(string[] args)
        {
            /// <summary>
            /// Events are a way for a class to notify other classes or objects when something of interest happens.
            /// They are based on the observer design pattern,
            /// where one object (the subject) maintains a list of its dependents (observers) and notifies them of any state changes,
            /// usually by calling one of their methods.
            /// </summary>
            Stock stock =  new Stock("MSFT");

            stock.PriceChanged += stock_PriceChanged;

            stock.Price = 135.00M;
            stock.Price = 150.00M;

            stock.PriceChanged -= stock_PriceChanged;

        }
    }
}
