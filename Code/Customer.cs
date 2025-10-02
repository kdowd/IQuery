using System;


namespace IQuery.Code
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
}
