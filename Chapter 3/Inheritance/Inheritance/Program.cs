namespace Inheritance
{
    internal class Program
    {
        public static void Display(Asset asset)
        {
            Console.WriteLine(asset.Name);
        }
        static void Main(string[] args)
        {
            #region Inheritance
            //Stock msft = new Stock
            //{
            //    Name = "MSFT",
            //    SharesOwned = 1000
            //};

            //Console.WriteLine(msft.Name);         // MSFT 
            //Console.WriteLine(msft.SharesOwned);  // 1000 

            //House mansion = new House
            //{
            //    Name = "Mansion",
            //    Mortgage = 250000
            //};

            //Console.WriteLine(mansion.Name);      // Mansion 
            //Console.WriteLine(mansion.Mortgage);  // 250000 
            //Display(msft);      // Polymorphic behavior: MSFT
            #endregion
            #region Casting and refrence Conversion
            //Stock msft = new Stock();
            //Asset a = msft; // Implicit upcasting: Stock to Asset

            //Console.WriteLine(a == msft);
            //Console.WriteLine(a.Name); // Accessing Asset property
            //Console.WriteLine(a.SharesOwned); // Compile-time error: Asset does not have SharesOwned

            //Stock msft = new Stock();
            //Asset a = msft; // Implicit upcasting: Stock to Asset
            //Stock s = (Stock)a; // Explicit downcasting: Asset back to Stock
            //Console.WriteLine(s.Name);
            //Console.WriteLine(s.SharesOwned);

            //Console.WriteLine(s == a); // True
            //Console.WriteLine(s == msft); // True

            //House h = new House();
            //Asset aa = h;
            //Stock ss = (Stock)a;
            #endregion
            #region Virtual Function Members
            //House mansion = new House { Name = "McMansion", Mortgage = 250000 };
            //Asset a = mansion;
            //Console.WriteLine(mansion.Liability);  // 250000 
            //Console.WriteLine(a.Liability);// 250000
            #endregion

        }
    }
}
