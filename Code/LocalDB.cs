
namespace IQuery.Code
{
    public class LocalDB
    {
        // add customers at instantiation
        private List<Customer> CustomersList = new()
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

        public LocalDB()
        {
            Console.WriteLine("Local DB class instantiated");
        }

        public IQueryable<Customer> GetCustomersQueryable()
        {
            // makes a copy and returns it for use by LINQ
            return CustomersList.AsQueryable();
        }

    }
}
