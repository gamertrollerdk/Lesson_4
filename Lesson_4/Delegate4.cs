using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Lesson_4
{
    // Define a delegate
    delegate void ProcessNumber(int num);

    class Delegates
    {
        static void Main(string[] args)
        {
            // Create an instance of the delegate
            ProcessNumber processNumber = ProcessAndPrint;

            Console.Write("Enter a number: ");
            int inputNumber = int.Parse(Console.ReadLine());

            // Call the delegate
            processNumber(inputNumber);
        }

        // Method to be used with the delegate
        static void ProcessAndPrint(int num)
        {
            if (num > 0)
            {
                Console.WriteLine($"The number {num} is positive.");
            }
            else if (num < 0)
            {
                Console.WriteLine($"The number {num} is negative.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }
        }
    }
}

