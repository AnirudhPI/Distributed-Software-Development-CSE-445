using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment2
{
    /* The OrderProcessingThread processes the order, checks for the credit card to be valid, then chooses random
     * tax percent and random location charge to calculate the total price for the number of parking slots ordered.*/
    public class OrderProcessing
    {
        private static Random random = new Random();
        private OrderClass order;

        public OrderProcessing(OrderClass order)
        {
            this.order = order;
        }

        public void ProcessOrder()
        {
            if (order != null)
            {
                Console.WriteLine("PROCESSING: ({0}) Parking Order {1}", 
                    Thread.CurrentThread.Name, order.ToString());
                
                // Validate the credit card
                if (ValidateCreditCard(order.CardNo))
                {
                    Console.WriteLine("VALIDATED: ({0}) Credit Card Number Valid", Thread.CurrentThread.Name);

                    // Calculate tax and location charge
                    // Random tax between 6% and 10%
                    // Random location charge between $2 and $5
                    double tax = random.Next(6, 10) / 100.0; 
                    double locationCharge = random.Next(200, 501) / 100.0; 

                    // Calculate the total charge
                    double totalCharge = (1 + tax) * (order.UnitPrice * order.Quantity) + locationCharge;

                    // Process the order (e.g., send confirmation, update records, etc.)
                    Console.WriteLine("PROCESSED: ({0}) Parking Order {1}\n\tTOTAL PRICE: {2}",
                        Thread.CurrentThread.Name, order.ToString(), totalCharge.ToString("C"));
                }
                else
                {
                    Console.WriteLine($"Invalid Credit Card: {order.CardNo}");
                    return;
                }
            }
            else
            {
                Console.WriteLine("PROCESSING: ({0}) No order received", Thread.CurrentThread.Name);
            }
        }

        private bool ValidateCreditCard(int cardNumber)
        {
            // Checks if the credit card number provided is in the valid range
            return (cardNumber >= 9999999 && cardNumber <= 100000000);
        }
    }
}
