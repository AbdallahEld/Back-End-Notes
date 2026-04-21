namespace Classes
{
    public class LineOfCreditAccount : BankAccount // Inheritance
    {
        public LineOfCreditAccount(string name, decimal intialBalance, decimal creditLimit) : base(name, intialBalance, -creditLimit) // Constructor Chaining
        {
        }

        public override void PerformMonthEndTransaction() // override
        {
            if(Balance < 0)
            {
                decimal interest = -Balance * 0.07m;
                MakeWithdrawal(interest, DateTime.Now, "charge monthly interest");
            }
        }

        protected override Transaction? CheckWithdrawalLimit(bool isOverdrawn) =>
            isOverdrawn
            ? new Transaction(-20, DateTime.Now, "Apply overdraft fee")
            : default;
    }
}
