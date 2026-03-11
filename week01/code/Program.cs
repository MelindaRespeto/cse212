using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Test MultiplesOf
        Console.WriteLine("Testing MultiplesOf:");
        double[] multiples = Arrays.MultiplesOf(7, 5);
        foreach (double num in multiples)
        {
            Console.WriteLine(num);
        }

        // Test RotateListRight
        Console.WriteLine("\nTesting RotateListRight:");
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        Arrays.RotateListRight(numbers, 2);
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}