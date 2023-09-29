﻿namespace P06.Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = null;
            Queue<string> customers = new Queue<string>();
            while ((input = Console.ReadLine()) != "End") 
            {
                if (input == "Paid")
                {
                    while (customers.Count > 0)
                    {
                        Console.WriteLine(customers.Dequeue());
                    }
                }
                else
                {
                    customers.Enqueue(input);
                }
            }
            Console.WriteLine($"{customers.Count} people remaining.");
        }
    }
}