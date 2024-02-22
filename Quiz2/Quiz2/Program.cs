using System;
using System.Collections.Generic;

class Program
{
    static List<(string, double)> orderItems = new List<(string, double)>();
    static bool orderPlaced = false;
    static int orderCount = 0;

    static void Main(string[] args)
    {
        Console.WriteLine("Ordering Application");

        int choice;
        do
        {
            Console.WriteLine("1. Add Item to Order");
            Console.WriteLine("2. View Order Summary");
            Console.WriteLine("3. Place Order");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        AddItem();
                        break;
                    case 2:
                        ViewOrderSummary();
                        break;
                    case 3:
                        PlaceOrder();
                        break;
                    case 4:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        } while (choice != 4);
    }

    static void AddItem()
    {
        Console.Write("Enter the item name to add to order: ");
        string itemName = Console.ReadLine();
        Console.Write("Enter the price of the item: ");
        double itemPrice;
        if (double.TryParse(Console.ReadLine(), out itemPrice))
        {
            orderItems.Add((itemName, itemPrice));
            Console.WriteLine("Item added to order successfully.");
        }
        else
        {
            Console.WriteLine("Invalid price format. Please enter a valid price.");
        }
    }

    static void ViewOrderSummary()
    {
        if (orderItems.Count == 0)
        {
            Console.WriteLine("Order is empty.");
        }
        else
        {
            Console.WriteLine("Order Summary:");
            double totalOrderPrice = 0;
            foreach (var (itemName, itemPrice) in orderItems)
            {
                Console.WriteLine($"- {itemName}: ${itemPrice}");
                totalOrderPrice += itemPrice;
            }
            Console.WriteLine($"Total Price of Order: ${totalOrderPrice}");
        }
        Console.WriteLine($"Total Orders: {orderCount}");
    }

    static void PlaceOrder()
    {
        if (orderItems.Count == 0)
        {
            Console.WriteLine("Cannot place empty order.");
        }
        else
        {
            Console.WriteLine("Order placed successfully.");
            orderItems.Clear();
            orderPlaced = true;
            orderCount++;
        }
    }
}

