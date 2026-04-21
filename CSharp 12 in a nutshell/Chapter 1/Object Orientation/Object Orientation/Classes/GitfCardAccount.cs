namespace Classes
{
    public class GiftCardAccount : BankAccount // Inheritance
    {
        private readonly decimal _monthlyDeposit = 0m;
        public GiftCardAccount(string name, decimal intializeBalance, decimal monthlyDeposit = 0) : base(name, intializeBalance) // Constructor Chaining
        {
            _monthlyDeposit = monthlyDeposit;
        }
        public override void PerformMonthEndTransaction() // override
        {
            if(_monthlyDeposit != 0)
            {
                MakeDeposit(_monthlyDeposit, DateTime.Now, "Add monthly deposit");
            }
        }
    }
}
