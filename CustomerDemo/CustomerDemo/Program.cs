using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CustomerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>
            {
                new Customer
                {
                    Firstname = "John", Lastname = "Smith",
                    DateOfBirth = new DateTime(1996, 12, 10), //22
                    Gender = Genders.Male
                },
                new Customer
                {
                    Firstname = "Jill", Lastname = "Smith",
                    DateOfBirth = new DateTime(2004, 12, 10),//14
                    Gender = Genders.Female
                },
                new Customer
                {
                    Firstname = "Sue", Lastname = "Smith",
                    DateOfBirth = new DateTime(1978, 12, 10),//40
                    Gender = Genders.Female
                }
            };
            Statistics s = new Statistics(customers);
            Console.WriteLine($"Average of customers is { s.GetAverageAges()}");
            Console.WriteLine($"Average of Males is { s.GetAverageAges(Genders.Male)}");
            Console.WriteLine($"Average of Females is { s.GetAverageAges(Genders.Female)}");

        }
    }
}
