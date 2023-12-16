using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
namespace Assignment2
{

    /*The Main Thread in the Parking Space Booking System initializes Parking Structure and
     * Parking Agents threads, facilitating their coordination through a Multi-Cell Buffer.
     * It also alerts Parking Agents when the Parking Structure threads complete their tasks */

    public class Program
    {
        private const int K = 1; // Number of parking structures
        private const int N = 5; // Number of parking agents

        private static Thread[] parkingAgentThreads = new Thread[N];
        private static Thread[] parkingStructureThreads = new Thread[K];
        private static ParkingStructure[] parkingStructures = new ParkingStructure[K];
        public static MultiCellBuffer mb = new MultiCellBuffer();

        static void Main()
        {
            // Initialize the Parking Structures
            for (int i = 0; i < K; ++i)
            {
                ParkingStructure parkingStructure = new ParkingStructure();
                parkingStructure.SetPrice();
                parkingStructures[i] = parkingStructure;
                parkingStructureThreads[i] = new Thread(parkingStructure.Start);
                parkingStructureThreads[i].Name = "ParkingStructure_" + i;
                parkingStructureThreads[i].Start();
                while (!parkingStructureThreads[i].IsAlive) ;
            }

            // Initialize the Parking Agents
            for (int i = 0; i < N; ++i)
            {
                ParkingAgent parkingAgent = new ParkingAgent();

                // Make Parking agent subscribe to the Parking structures for the pricecut event
                for (int j = 0; j < K; ++j)
                {
                    parkingAgent.Subscribe(parkingStructures[j]);

                }

                parkingAgentThreads[i] = new Thread(parkingAgent.Start);
                parkingAgentThreads[i].Name = "ParkingAgent_" + i;
                parkingAgentThreads[i].Start();
                while (!parkingAgentThreads[i].IsAlive) ;
            }

            // Wait for the Parking Structures to perform MAX_PRICE_CUTS price cuts
            for (int i = 0; i < K; ++i)
            {
                while (parkingStructureThreads[i].IsAlive) ;
            }

            // Alert the Parking Agents that the Parking Structures are not active
            for (int i = 0; i < N; ++i)
            {
                ParkingAgent.ParkingStructuresActive = false;
            }

            // Wait for Parking Agents to close
            for (int i = 0; i < N; ++i)
            {
                while (parkingAgentThreads[i].IsAlive) ;
            }

            Console.WriteLine("\n\nALL ORDERS FINISHED");

            // Wait for user to hit a button
            Console.WriteLine("PRESS ENTER TO QUIT");
            Console.ReadLine();
        }

    }
}
            



