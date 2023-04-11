using System;

namespace array_jakob_cook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a whole number for the array size.");
            int arraySize = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[arraySize];
            int sum = 0;

            for (int i < numbers.Length; int++)

                Console.WriteLine("Enter a wole number to add to the array.");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
            sum += numbers[i];


            Console.WriteLine($"The sum of the array is {sum}\n");

            Array.Sort(numbers);

            Console.WriteLine("Array:");
            foreach (int numbers in numbers)

                Console.WriteLine(number);
        }
    }
}
