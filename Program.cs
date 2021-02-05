using System;
using System.Collections.Generic;

namespace RandomSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            var randomNumberHolder = new List<int>();

            for (int i = 1; i < 21; i++)
            {
                randomNumberHolder.Add(random.Next(1, 50));
            }
            foreach (var number in randomNumberHolder)
            {
                Console.WriteLine($"Random numbers: {number}");
            }

            var squaredNumberList = new List<int>();

            foreach (var number in randomNumberHolder)
            {
                var squaredNumber = number * number;
                squaredNumberList.Add(squaredNumber);
                Console.WriteLine($"Squared numbers: {squaredNumber}");
            }

            squaredNumberList.RemoveAll(number => number % 2 != 0);
            
            foreach (var number in squaredNumberList)
            {
                Console.WriteLine($"Removed odd numbers: { number}");
                
            }
            
        }
    }
}
