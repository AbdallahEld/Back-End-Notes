namespace Inheritance
{
    public abstract class Asset
    {
        //public string Name;
        //public virtual decimal Liability => 0; // Virtual property to be overridden by derived classes
        //public virtual Asset Clone() => new Asset { Name = Name }; // Virtual method for cloning
        public abstract decimal NetValue { get; } // Abstract method to be implemented by derived classes
    }
}
