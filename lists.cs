using System;
using System.Collections.Generic;

namespace list_tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // step-1
            // A basic list example

            var names = new List<string> { "<name>", "Deepu", "pallavi" };
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
            
            // step-2
            // Modify list contents
            
            Console.WriteLine();
            names.Add("twincy");
            names.Add("Bunnu");
            names.Remove("deep");
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            Console.WriteLine($"My name is {names[0]}");
            Console.WriteLine($"I've added {names[2]} and {names[3]} to the list");

            Console.WriteLine($"The list has {names.Count} people in it");

            // step-3
            // Search and sort lists

            var index = names.IndexOf("Felipe");
            if (index == -1)
            {
                Console.WriteLine($"When an item is not found, IndexOf returns {index}");
            }
            else
            {
                Console.WriteLine($"The name {names[index]} is at index {index}");
            }

            index = names.IndexOf("Not Found");
            if (index == -1)
            {
                Console.WriteLine($"When an item is not found, IndexOf returns {index}");
            }
            else
            {
                Console.WriteLine($"The name {names[index]} is at index {index}");

            }

            names.Sort();
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

                  
// See if you can put together some of the concepts from this 
// and earlier lessons. Expand on what you've built so far with
// Fibonacci Numbers.            
// Try to write the code to generate the first 20 numbers in the sequence. (As a hint, the 20th Fibonacci number is 6765.)

            
            // step-4
            // list of other lists
            
            var fibonacciNumbers = new List<int> {1, 1};

            var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
            var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

            fibonacciNumbers.Add(previous + previous2);

            foreach (var item in fibonacciNumbers)
                Console.WriteLine(item);

            // step-5
            // challenge
            
            // step-6
            // completed challenge(step-4 same code should mention here)
        }
    }
}

OUTPUT :

Hello <NAME>!
Hello DEEPU!
Hello PALLAVI!

Hello <NAME>!
Hello DEEPU!
Hello PALLAVI!
Hello DEEP!
Hello BUNNU!
My name is <name>.
I've added pallavi and deep to the list.
The list has 5 people in it
The name pallavi is at index 2
When an item is not found, IndexOf returns -1
Hello <NAME>!
Hello BUNNU!
Hello DEEP!
Hello DEEPU!
Hello PALLAVI!
1
1
2