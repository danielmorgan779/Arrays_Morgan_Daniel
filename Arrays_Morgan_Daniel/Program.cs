using System;

namespace Arrays_Morgan_Daniel
{
    class Program
    {
        static void Main(string[] args)
        {   // Asks the user to enter the array size
            Console.WriteLine("Enter a whole number for array size.");
            int arraySize = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[arraySize];
            int sum = 0;

            // Asks the user to input values for all the array elements that the user inputted
            for(int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Enter a whole number to add to the array.");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                sum += numbers[i];
            }
            // Adds the numbers and prints the sum of them
            Console.WriteLine($"The sum of the array is {sum}");

            // This sorts the numbers the user inputted in the correct order
            Array.Sort(numbers);
             // Prints the number is order
            Console.WriteLine("Array:");
            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
