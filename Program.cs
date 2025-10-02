
using System;
using IQuery.Code;

namespace Application
{


    class App
    {


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