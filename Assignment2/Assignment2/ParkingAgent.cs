using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment2
{
    /* A ParkingAgent evaluates the price, generates an OrderClassObject,
     * and sends the order to one of the free cells in the MultiCellBuffer.*/
    public class ParkingAgent
    {
        private static Random random = new Random();
        private double currentPrice = 0.0; // Current Unit Price for the parking slot
        private double previousPrice = 20.0; // Previous Unit Price for the parking slot
        private static bool parkingStructuresActive = true;
        private bool baseOrder = true;
        private bool ispricecutEvent = false;

        private string parkingStructureId;
        public static bool ParkingStructuresActive
        {
            get { return parkingStructuresActive; }
            set { parkingStructuresActive = value; }
        }

        // Random method to calculate how much to order if a priceCut was identified
        public int CalculateQuantityToOrder()
        {
            // Order more if the priceCut was more
            if (previousPrice - currentPrice >= 8) 
            {
                //order 10
                return 10;

            }
            // Order less if there was no huge difference
            else if (previousPrice - currentPrice < 8 && previousPrice - currentPrice > 0) 
            {
                //order 5 default
                return 5;
            }
            else
            {
                return 0;
            }
        }

        // Execution thread for the ParkingAgent class.
        // Creates a base order continuously until ParkingStructure threads are no longer active.
        public void Start()
        {
            //Thread.Sleep(1000);
            // Check if ParkingStructres are no longer active
            while (parkingStructuresActive)
            {
                // Check if baseOrder required
                if (baseOrder)
                {
                    if (!ispricecutEvent) 
                    {
                        //Thread.Sleep(500);
                        CreateBaseOrder();
                    }
                    else // Go for priceCutOrder
                    {
                        //Thread.Sleep(500);
                        if (random.Next(1, 3) == 2) // randomising price cut event reaction by thread
                        {
                            Console.WriteLine("ACCEPTING PRICE CUT AND PLACING ORDER ({0})",
                                Thread.CurrentThread.Name);
                            CreatePriceCutEventOrder();
                        }
                        else
                        {
                            Console.WriteLine("SKIPPING PRICECUT: Parking Agent Thread ({0})",
                                Thread.CurrentThread.Name);
                        }
                    }
                }
                else
                {
                    // No orders are needed so sleep the thread for some time
                    Console.WriteLine("WAITING: Parking Agent Thread ({0})", Thread.CurrentThread.Name);
                    Thread.Sleep(1000);
                    baseOrder = true;
                }

            }
            Console.WriteLine("CLOSING: Parking Agent Thread ({0})", Thread.CurrentThread.Name);
        }

        // Set all args

        public void IssueBulkOrder(PriceCutEventArgs e)
        {
            ispricecutEvent = true;
            currentPrice = e.CurrentPrice;
            previousPrice = e.Previousprice;
            parkingStructureId = e.Id;
        }

        // Hook the PriceCut event to the CreatePriceCutEventOrder method
        public void Subscribe(ParkingStructure parkingStructure) //call this main class
        {
            Console.WriteLine("SUBSCRIBING: Price Cut Event");
            parkingStructure.PriceCut += IssueBulkOrder;
        }

        // Called once the Parking Agent thread has come back from sleeping.
        private void CreateBaseOrder()
        {
            Console.WriteLine("CREATING: Base Order ({0})", Thread.CurrentThread.Name);

            // Tell system no order is needed
            baseOrder = false;
            // Create an order
            OrderClass order = new OrderClass(
                senderId: Thread.CurrentThread.Name,
                recieverId: parkingStructureId,
                cardNo: 10000000,
                quantity: 1,
                unitPrice: previousPrice
            );

            Program.mb.SetOneCell(order);
        }

        // Called once a PriceCut event occurs.
        private void CreatePriceCutEventOrder()
        {
            Console.WriteLine("CREATING: Base Order ({0})", Thread.CurrentThread.Name);


            int quantityToOrder = CalculateQuantityToOrder();

            // Create an order
            OrderClass order = new OrderClass(
               senderId: Thread.CurrentThread.Name,
               recieverId: parkingStructureId,
               cardNo: 20000000,
               quantity: quantityToOrder,
               unitPrice: currentPrice
           );

            // Send the order to the MultiCellBuffer
            Program.mb.SetOneCell(order);
            ispricecutEvent = false;
        }
    }
}
