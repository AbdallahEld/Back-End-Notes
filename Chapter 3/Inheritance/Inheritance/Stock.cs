namespace Inheritance
{
    public class Stock : Asset
    {
        public long SharesOwned;
        public decimal CurrentPrice;
        public override decimal NetValue => SharesOwned * CurrentPrice; // Override the abstract property to calculate net value
    }
}
