namespace Struct
{
    public struct WebOptions
    {
        string protocol;

        // always make sure your struct can be working properly when you use default intializers
        // in our example here the Protocol will never be null cause it check if its null it return 
        // https making sure it wont return null since theres no such thing as Protocol null
        public string Protocol
        {
            get => protocol ?? "https";
            set => protocol = value;
        }
    }
}
