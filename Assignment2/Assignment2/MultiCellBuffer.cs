using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment2
{
    /* Buffer is used for synchronized communication between Parking structure threads and Parking agent threads.
     The buffer is of size 3 in this case to store objects of class OrderClass. */
    public class MultiCellBuffer
    {
        // Semaphores to control read/write access
        Semaphore write = new Semaphore(3, 3);
        Semaphore read = new Semaphore(2, 2);

        // Helpers to keep track of buffer position
        int head = 0;
        int tail = 0;
        int nElements = 0;

        object[] cells = new object[3]; // 3 is the size if the buffer

        // Sets the value of free cell in the buffer. Locks, Monitors, and Semaphores for synchronization.
        public void SetOneCell(OrderClass order)
        {
            write.WaitOne();
            Console.WriteLine("THREAD: " + Thread.CurrentThread.Name + " Entered Write");
            lock (this)
            {
                // Wait till a free space is available in the buffer
                while (nElements == 3)
                {
                    Monitor.Wait(this);
                }

                cells[tail] = order;
                tail = (tail + 1) % 3;

                Console.WriteLine("WRITING: ({0}) Multi-Cell Buffer\n\n{1}\n, Elements: {2}\n",
                    Thread.CurrentThread.Name,
                    order,
                    nElements
                );


                nElements++; // Move to the next available space
                Console.WriteLine("THREAD: ({0}) Leaving Write", Thread.CurrentThread.Name);
                write.Release();
                Monitor.Pulse(this);
            }
        }

        // Gets the value of cell in the buffer. Locks, Monitors, and Semaphores for synchronization.
        public OrderClass GetOneCell()
        {
            read.WaitOne();
            Console.WriteLine("THREAD: " + Thread.CurrentThread.Name + " Entered Read");
            lock (this)
            {
                OrderClass order;

                // Wait till an order is available in the buffer
                while (nElements == 0)
                {
                    Monitor.Wait(this);
                }

                // Extract the order from the cell
                order = (OrderClass)cells[head];

                head = (head + 1) % 3;
                nElements--; // Decrement to indicate the cell is read

                Console.WriteLine("READING: ({0}) Multi-Cell Buffer\n{1}\n, Elements: {2}\n",
                    Thread.CurrentThread.Name,
                    order,
                    nElements
                );

                Console.WriteLine("THREAD: ({0}) Leaving Read", Thread.CurrentThread.Name);
                read.Release();
                Monitor.Pulse(this);
                return order;
            }

        }
    }
}
