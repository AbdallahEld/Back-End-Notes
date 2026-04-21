using Classes;

namespace Object_Orientation
{ 
    internal class Program
    {
        public static void DrawLine(int length, char symbol)
        {
            while(length > 0)
            {
                Console.Write(symbol);
                length--;
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            #region Bank Account
            //BankAccount account = new BankAccount("Abdallah", 1000);
            //account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
            //account.MakeDeposit(200, DateTime.Now, "Friend pay me back");
            //Console.WriteLine($"Account {account.Number} was created, Owner is : {account.Owner}, Balance is : {account.Balance}");
            //Console.WriteLine(account.GetAccountHistory()); 
            #endregion

            #region MyRegion
            //Gift Card Account
            var giftCard = new GiftCardAccount("gift card", 100, 50);
            giftCard.MakeWithdrawal(20, DateTime.Now, "get expensive coffe");
            giftCard.MakeWithdrawal(50, DateTime.Now, "buy groceries");
            giftCard.PerformMonthEndTransaction();
            giftCard.MakeDeposit(27.50m, DateTime.Now, "add some additional spending money");
            Console.WriteLine("----- Gift Card Account -----");
            Console.WriteLine(giftCard.GetAccountHistory());
            DrawLine(100, '*');

            //Interest Earning Account
            var savings = new InterestEarningAccount("saving account", 10000);
            savings.MakeDeposit(750, DateTime.Now, "save some money");
            savings.MakeDeposit(1250, DateTime.Now, "Add more savings");
            savings.MakeWithdrawal(250, DateTime.Now, "Needed to pay monthly bills");
            savings.PerformMonthEndTransaction();
            Console.WriteLine("----- Interest Earning Account -----");
            Console.WriteLine(savings.GetAccountHistory());
            DrawLine(100, '*');

            //Line of Credit Account
            var lineOfCredit = new LineOfCreditAccount("line of credit", 0,2000);
            lineOfCredit.MakeWithdrawal(1000m, DateTime.Now, "Take out monthly advance");
            lineOfCredit.MakeDeposit(50m, DateTime.Now, "Pay back small amount");
            lineOfCredit.MakeWithdrawal(5000m, DateTime.Now, "Emergency funds for repairs");
            lineOfCredit.MakeDeposit(150m, DateTime.Now, "Partial restoration on repairs");
            lineOfCredit.PerformMonthEndTransaction();
            Console.WriteLine("----- Line of Credit Account -----");
            Console.WriteLine(lineOfCredit.GetAccountHistory());
            DrawLine(100, '*');
            #endregion
        }
    }
}
