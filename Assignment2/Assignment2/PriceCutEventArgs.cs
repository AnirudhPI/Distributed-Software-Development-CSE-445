using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    /* Custom class that derives EventArgs. Adds Id, previousPrice and currentPrice
     * fields to pass to the ParkingAgent.*/
    public class PriceCutEventArgs : EventArgs
    {
        private double previousprice;
        private double currentPrice;
        private string id;

        public PriceCutEventArgs(string id, double previousprice, double currentPrice)
        {
            Id = id;
            this.previousprice = previousprice;
            this.currentPrice = currentPrice;
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public double Previousprice
        {
            get { return previousprice; }
            private set { previousprice = value; }
        }
        public double CurrentPrice
        {
            get { return currentPrice; }
            private set { currentPrice = value; }
        }
    }
}
