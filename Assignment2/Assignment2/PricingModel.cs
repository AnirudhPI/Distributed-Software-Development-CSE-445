using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public static class PricingModel
    {
        private static Random random = new Random();

        // The CalculatePrice is a simple method to return a random price from 10 to 40
        public static double CalculatePrice()
        {
            return random.Next(10, 41);
        }
    }
}
