


namespace IQuery.Code
{
    public class LocalDB
    {
        public List<Customer> Customers { get; } = new List<Customer>
        {
            new Customer(4, "Sungji", Products.Shirt),
            new Customer(20, "Sunny", Products.Golf),
            new Customer(56, "Muskan", Products.TeeShirt),
            new Customer(80, "Logan", Products.Shirt),
            new Customer(87, "Logan", Products.Shirt),
            new Customer(90, "Shishir", Products.Shirt),
            new Customer(50, "Chris", Products.Shirt),
            new Customer(80, "Chris", Products.Shirt),
            new Customer(55, "Zoe", Products.Shirt),
            new Customer(18, "Pooja", Products.Shirt),
            new Customer(94, "Pooja", Products.Shirt),
            new Customer(66, "Pooja", Products.Shirt),
            new Customer(100, "Rehan", Products.Shirt),
            new Customer(100, "Sachin", Products.Shirt),
            new Customer(100, "Masrafe", Products.Shirt)
        };

        public IQueryable<Customer> GetCustomersQueryable()
        {
            return Customers.AsQueryable();
        }

    }
}
