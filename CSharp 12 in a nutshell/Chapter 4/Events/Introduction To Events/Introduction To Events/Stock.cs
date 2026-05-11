using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Introduction_To_Events.Program;

namespace Introduction_To_Events
{
    internal class Stock
    {
        string symbol;
        decimal price;

        public Stock(string symbol) => this.symbol = symbol;

        public event EventHandler<PriceChangedEventArgs> PriceChanged;

        protected virtual void OnPriceChanged(PriceChangedEventArgs e)
        {
            PriceChanged?.Invoke(this, e);
        }

        public decimal Price
        {
            get => price;
            set
            {
                if (price == value) return;
                decimal oldPrice = price;
                price = value;
                OnPriceChanged(new PriceChangedEventArgs(oldPrice, price));
            }

        }
    }
}
