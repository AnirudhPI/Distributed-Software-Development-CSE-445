using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment2
{
    /* The Parking structure uses a pricing model to generate a random price for the slot.
     * If the new price is lower than the previous price, it emits a promotional event and calls
     * the parking agents that have subscribed to the event. The Parking structure receives order
     * from the MultiCellBuffer and creates a new thread to process the order.*/

    public class ParkingStructure
    {
        private const int MAX_PRICE_CUTS = 10; // Maximum Price Cuts allowed
        private int priceCutCount = 1;
        private double currentPrice = 0.0; // Current Unit Price for the parking slot
        private double previousPrice = 20.0; // Previous Unit Price for the parking slot

        private ArrayList processingThreads = new ArrayList();

        public delegate void PriceCutHandler(PriceCutEventArgs e);
        public event PriceCutHandler PriceCut;


        public double CurrentPrice { get; private set; }
        public double PreviousPrice { get; private set; }

        // Event fired once a PriceCut has occurred.
        private void PriceCutEvent()
        {
            if (PriceCut != null)
            {
                // PriceCut event fired
                Console.WriteLine("\nEVENT: Performing Price Cut Event (#{0}) ({1})\n", priceCutCount, Thread.CurrentThread.Name);
                Console.WriteLine("NEW PRICE AFTER EVENT: ({0})", currentPrice);
                priceCutCount++;
                PriceCut(new PriceCutEventArgs(Thread.CurrentThread.Name, previousPrice, currentPrice));//pass pricing model
                //Thread.Sleep(600);

            }
            else
            {
                Console.WriteLine("ERROR: No PriceCut event subscribers");
            }
        }

        // Retrieve orders from the MultiCellBuffer and start OrderProcessing threads
        private void ProcessOrders(OrderClass order)
        {
            if (order != null)
            {
                Console.WriteLine("RECEIVING: Order for Parking Structure ({0})", Thread.CurrentThread.Name);
                OrderProcessing orderProcessor = new OrderProcessing(order);
                Thread processingThread = new Thread(new ThreadStart(orderProcessor.ProcessOrder));
                processingThreads.Add(processingThread);
                processingThread.Name = "Processor_" + Thread.CurrentThread.Name;
                processingThread.Start();
            }
            else
            {
                Console.WriteLine("SKIPPING: Order not for Parking Structure ({0})", Thread.CurrentThread.Name);
            }
        }

        // Obtain price from the PricingModel.
        public void SetPrice()
        {
            previousPrice = currentPrice;
            currentPrice = PricingModel.CalculatePrice();
        }

        // Sets the price from the PricingModel, fires PriceCut events if price is lowered,
        // and processes any orders received from the Multi-Cell buffer.
        public void Start()
        {
            Thread.Sleep(500);
            while (priceCutCount <= MAX_PRICE_CUTS) // Terminate after 10 price cuts
            {
                SetPrice();

                // Check for price cut and emit event
                if (currentPrice < previousPrice)
                {
                    PriceCutEvent();
                }

                previousPrice = currentPrice;

                ProcessOrders(Program.mb.GetOneCell());
            }

            foreach (Thread item in processingThreads)
            {
                while (item.IsAlive) ;
            }

            Console.WriteLine("CLOSING: Parking agent Thread ({0})", Thread.CurrentThread.Name);
        }
    }
}
