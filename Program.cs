
using IQuery.Code;

namespace Application
{

    class App
    {


        public static void MakeDB()
        {
            var db = new LocalDB();
            IQueryable<Customer> query = db.GetCustomersQueryable();

            //var or List<Customer> lamba function!
            var results = query.Where(c => c.Name == ("Sunny")).ToList();

            // case insensitive: make both lowerCase();
            // var results = query.Where(c => c.Name.ToLower() == ("logan").ToLower()).ToList();

            // more complex query
            //var results = query.Where(c => c.Name == ("Pooja")).Where(c => c.Revenue > 90).ToList();


            if (results.Count() > 0)
            {
                showResults(results);
            }
            else
            {
                Console.WriteLine("Query results are empty.");
            }

        }

        //List<Customer> r - this is not copied. In C++ it would be.
        public static void showResults(List<Customer> r)
        {
            foreach (Customer item in r)
            {
                Console.WriteLine($"{item.Name}, {item.Item}, {item.Revenue}");
            }
        }

        public static void Main()
        {

            MakeDB();

            Console.ReadKey();
        }
    }
}