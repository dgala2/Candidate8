using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace CustomerDemo
{
   

    public class Statistics : IStatistics
    {
        private List<Customer> customers;

        public Statistics(List<Customer> _customers)
        {
            customers = _customers;
        }

        public double GetAverageAges()
        {
            return customers.Average(x => x.Age);
        }
        public double GetAverageAges(Genders gender)
        {
            return customers.Where(x=> x.Gender == gender).Average(x => x.Age);

        }
    }
}
