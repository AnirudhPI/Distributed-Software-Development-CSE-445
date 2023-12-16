using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    // Order from Parking Agent to Parking Structure through MultiCellBuffer
    public class OrderClass
    {
        private string senderId; // The identity of the sender
        private string recieverId; // The identity of the reciever
        private int cardNo; // Credit card number
        private int quantity; // Number of parking slots requested
        private double unitPrice; // Price set by Parking Structure

        public OrderClass(string senderId, string recieverId, int cardNo, int quantity, double unitPrice)
        {
            this.senderId = senderId;
            this.recieverId = recieverId;
            this.cardNo = cardNo;
            this.quantity = quantity;
            this.unitPrice = unitPrice;

        }

        public override string ToString()
        {
            return "ORDER\n\t{ID: " + SenderId
                + "}\n\t{CARD_NO: " + CardNo
                + "}\n\t{Quantity: " + Quantity
                + "}\n\t{UnitPrice: " + UnitPrice + "}";
        }

        // Accessor/Mutator for all fields in OrderClass

        public string SenderId
        {
            get
            {
                return senderId;
            }
            set
            {
                senderId = value;
            }
        }

        public string RecieverId
        {
            get
            {
                return recieverId;
            }
            set
            {
                recieverId = value;
            }
        }
        public int CardNo
        {
            get
            {
                return cardNo;
            }
            set
            {
                cardNo = value;
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }

        public double UnitPrice
        {
            get
            {
                return unitPrice;
            }
            set
            {
                unitPrice = value;
            }
        }
    }
}
