using System;
using System.Collections.Generic;

namespace Orders1
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, decimal> priceByProduct = new Dictionary<string, decimal>();

            Dictionary<string, int> quantytyByProduct = new Dictionary<string, int>();

            while (true)
            {
                string line = Console.ReadLine();

                if(line == "buy")
                {
                    break;
                }

                string[] parts = line
                    .Split();

                string product = parts[0];
                decimal price = decimal.Parse(parts[1]);
                int quantyty = int.Parse(parts[2]);

                if(priceByProduct.ContainsKey(product))
                {
                    quantytyByProduct[product] += quantyty;
                    priceByProduct[product] = price;
                }
                else
                {
                    quantytyByProduct.Add(product, quantyty);
                    priceByProduct.Add(product, price);
                }
            }
            foreach (var kvp in priceByProduct)
            {
                string product = kvp.Key;
                decimal price = kvp.Value;
                int quntity = quantytyByProduct[product];
                decimal totalPrice = price * quntity;

                Console.WriteLine($"{product} -> {totalPrice}");
            }
        }
    }
}
