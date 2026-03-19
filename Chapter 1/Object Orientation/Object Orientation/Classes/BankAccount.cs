using System.Text;

namespace Classes
{
    //Class
    public class BankAccount
    {
        private static int s_AccountNumberSeed = 1234567890; // Encapsulation
        
        //Properties
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (var item in _allTransactions)
                {
                    balance += item.Amount;
                }

                return balance;
            }
        }

        //Constructor
        private readonly decimal _minimumBalance;
        public BankAccount(string name, decimal intialBalance) : this(name, intialBalance, 0) { }
        public BankAccount(string name, decimal intialBalance, decimal minimumBalance)
        {
            Number = s_AccountNumberSeed.ToString();
            s_AccountNumberSeed++;

            Owner = name;
            _minimumBalance = minimumBalance;
            if(intialBalance > 0)
            {
                MakeDeposit(intialBalance, DateTime.Now, "Initial balance");
            }
        }

        private List<Transaction> _allTransactions = new List<Transaction>();

        //Methods
        public void MakeDeposit(decimal amount, DateTime dateTime, string note)
        {
            if(amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }
            var deposit = new Transaction(amount, dateTime, note);
            _allTransactions.Add(deposit);
        }

        public void MakeWithdrawal(decimal amount, DateTime dateTime, string note)
        {
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(amount);
            Transaction? overdraftTransaction = CheckWithdrawalLimit(Balance - amount < _minimumBalance);
            Transaction? withdrawal = new(-amount, dateTime, note);
            _allTransactions.Add(withdrawal);
            if(overdraftTransaction != null)
                _allTransactions.Add(overdraftTransaction);
        }

        protected virtual Transaction? CheckWithdrawalLimit(bool isOverdrawn) // protected = can be only called from derived classes
        {
            if(isOverdrawn)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }
            else
            {
                return default;
            }
        }

        public string GetAccountHistory()
        {
            var report = new StringBuilder();

            decimal balance = 0;
            report.AppendLine("Date\t\tAmount\tBalance\tNote");
            foreach( var item in _allTransactions )
            {
                balance += item.Amount;
                report.AppendLine($"{item.DateTime.ToShortDateString()}\t{item.Amount}\t{balance}\t{item.Notes}");
            }

            return report.ToString();
        }

        public virtual void PerformMonthEndTransaction() { } // Polymorphism
    }
}
