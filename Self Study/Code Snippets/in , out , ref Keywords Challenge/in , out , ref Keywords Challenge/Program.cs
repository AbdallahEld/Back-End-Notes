namespace in___out___ref_Keywords_Challenge
{
    public readonly struct PriceRange
    {
        public decimal Min { get; }
        public decimal Max { get; }
        public decimal Spread => Max - Min;

        public PriceRange(decimal min, decimal max)
        {
            Min = min;
            Max = max;
        }
    }
    

    public class PricingEngine
    {
        // Method A
        // range is a copy, caller never sees the change
        public bool TryAdjustRange(PriceRange range, decimal adjustment)
        {
            range = new PriceRange(range.Min + adjustment, range.Max + adjustment);
            return true; // callers PriceRange is completely unchanged
        }

        // Fixed
        public bool TryAdjustRange(ref PriceRange range, decimal adjustment)
        {
            range = new PriceRange(range.Min + adjustment, range.Max + adjustment);
            return true; // callers PriceRange is now updated
        }

        // Method B
        // SUBOPTIMAL - PriceRange is 16 bytes (two decimals = 8 bytes each)
        // passing by value copies 16 bytes on every call
        public decimal CalculateSpread(PriceRange range)
            => range.Spread;

        // Fixed
        // Optimized - passess 8-byte pointer instead of 16-byte copy
        // readonly struct = no defensive copy = full performance
        public decimal CalculateSpread(in PriceRange range)
            => range.Spread;

        // if PriceRange were a mutable struct, in would actually cause defensive copies
        // inside the method - and you would lose the performance benefit. readonly struct +
        // in is the combination that works correctly.

        // Method C
        public bool TryNormalizeRange(PriceRange range, decimal min, decimal max)
        {
            if (min >= max)
            {
                range = default; // PriceRange { Min=0, Max=0 }
                return false;
            }
            range = new PriceRange(min, max);
            return true;
        }
        // The misuse - ignoring the return value and using range anyway:
        // Fixed 
        public bool TryNormalizeRange(out PriceRange range, decimal min, decimal max)
        {
            if (min >= max)
            {
                range = default;
                return false;
            }
            range = new PriceRange(min, max);
            return true;
        }

    }
    /*
     * Question 1: Method A is broken by design. Why doesn't it work as intended? Fix it with the right keyword — and explain why that keyword is the correct choice.
     * Question 2: Method B is correct but suboptimal. Why? Fix it with one keyword and explain the performance reason.
     * Question 3: Method C is correct as-is. But there's one scenario where its caller could misuse it. Write that misuse scenario and explain what goes wrong.
     */
    internal class Program
    {
        static void Main(string[] args)
        {

            // Method A Caller
            var engine = new PricingEngine();
            var range = new PriceRange(10, 20);
            engine.TryAdjustRange(ref range, 5);
            Console.WriteLine(range.Min);
            // The real reason without ref, the method recives a copy of the struct. Any
            // reassignment to that parameter stays local to the method and is discarded when it
            // returns. ref makes the parameter an alias for the caller actual variable.
        }
    }
}
