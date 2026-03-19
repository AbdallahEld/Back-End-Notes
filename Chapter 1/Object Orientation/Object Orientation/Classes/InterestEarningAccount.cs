namespace Classes
{
    public class InterestEarningAccount : BankAccount // Inheritance
    {
        public InterestEarningAccount(string name, decimal intialBalance) : base(name, intialBalance) // Constructor Chaining
        {
        }

        public override void PerformMonthEndTransaction() // override
        {
            if (Balance > 500m)
            {
                decimal interest = Balance * 0.02m;
                MakeDeposit(interest, DateTime.Now, "apply monthly interest");
            }
        }
    }
}
