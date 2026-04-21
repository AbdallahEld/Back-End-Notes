namespace Inheritance
{
    public class House : Asset
    {
        public decimal Mortgage;
        //public override decimal Liability => Mortgage;
        //public override Asset Clone() => new House { Name = Name, Mortgage = Mortgage };
        public override decimal NetValue => Mortgage;
    }
}
