# Assignment 2: Event-driven programming and Multithreading
Files included:
- Program.cs: contains main method
- ParkingStructure.cs: contains pricingModel() and priceCut events
- ParkingAgent.cs: contains ParkingAgent class and orderCreated events
- MultiCellBuffer.cs: contains setOneCell and getOneCell along with the rest of the MultiCellBuffer information
- PriceCutEventArgs.cs: contains PriceCutEventArgs class and constructor
- OrderClass.cs: class definition for an orderObject
- OrderProcessing.cs: contains order processing functions

There are 5 Agent threads, along with 3 Structure threads, started in the main method. A multi-cell buffer is also created with 3 as the default size. The Agent threads execute until the Structure threads end (which is after there have been 10 priceCut events). A new order is created everytime the price is decreased. The Agent also creates its own orders regardless of the price decrease (to keep business going). 

The Parking structure uses a pricing model to generate a random price for the slot. If the new price is lower than the previous price, it emits a promotional event and calls the parking agents that have subscribed to the event. The Parking structure receives order from the MultiCellBuffer and creates a new thread to process the order.

A ParkingAgent evaluates the price, generates an OrderClassObject,and sends the order to one of the free cells in the MultiCellBuffer.

The pricingModel randomly generates a price between $10 and $40. The price is only changed when the new price is not the same as the older price. But, a priceCut event is only emitted when the price has been decreased.
