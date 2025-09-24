namespace LibraryConsoleApp
{
    public class Customer
    {
        public string Name { get; }
        public string Id { get; }

        public Customer(string name, string id)
        {
            Name = name;
            Id = id;
        }

        public override string ToString()
        {
            return $"{Name} (ID: {Id})";
        }
    }
}
