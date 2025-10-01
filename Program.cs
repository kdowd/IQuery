using System;

namespace YourNamespace
{
    public enum Products
    {
        Shirt,
        TeeShirt,
        Golf,
        Shorts
    }


    public class Customer
    {
        public int Revenue { get; set; } = 0;
        public string Name { get; set; } = "";
        public Products Item { get; set; }

        public Customer(int revenue, string name, Products p)
        {
            Revenue = revenue;
            Name = name;
            Item = p;
        }
    }

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



    class App
    {

        public static void GetEvenNumbers()
        {

            // out data, a list is always queriable by C#
            List<int> numbers = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

            // run query on a List<>
            var queryResults = from num in numbers where ((num % 2) == 0) select num;

            // loop query results
            if (queryResults.Count() > 0)
            {
                foreach (int num in queryResults)
                {
                    Console.Write($"{num} ");
                }
            }
            else
            {
                Console.WriteLine("Um! no results...");
            }

        }


        public static void MakeDB()
        {
            Console.WriteLine("creating db");
            var db = new LocalDB();

            IQueryable<Customer> t1 = db.GetCustomersQueryable();


            //var or List<Customer> arrow functions!
            var queryResult = t1.Where(c => c.Name == ("Sunny")).ToList();

            // case insensitive: make both lowerCase();
            //var queryResult = t1.Where(c => c.Name.ToLower() == ("logan").ToLower()).ToList();

            // more complex query
            //var queryResult = t1.Where(c => c.Name == ("Pooja")).Where(c => c.Revenue > 90).ToList();

            if (queryResult.Count() > 0)
            {
                foreach (Customer item in queryResult)
                {
                    Console.WriteLine($"{item.Name}, {item.Item}, {item.Revenue}");
                }
            }
            else
            {
                Console.WriteLine("Query results are empty.");
            }

        }

        public static void Main()
        {
            MakeDB();
            //GetEvenNumbers();
            Console.ReadKey();
        }
    }
}



// unused - see enums instead
public static class DictionaryOfProducts
{
    public static Dictionary<string, string> AllProducts { get; } = new Dictionary<string, string>
        {
            {"ShirtOne", "Linen Shirt"},
            {"ShortsOne", "Golf Shorts"},
            {"ShortsTwo", "Board Shorts"},
            {"HatOne", "Marino Beeny"}
        };
}