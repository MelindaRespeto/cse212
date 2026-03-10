using System;
using System.Collections.Generic;

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number'
    /// followed by multiples of 'number'.
    /// Example: MultiplesOf(7,5) -> {7,14,21,28,35}
    /// </summary>
    public static double[] MultiplesOf(double number, int length)
    {
        double[] result = new double[length];
        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }
        return result;
    }

    // Function: RotateListRight
    public static void RotateListRight<T>(List<T> list, int positions)
    {
        if (list == null || list.Count == 0 || positions == 0)
            return;

        int count = list.Count;
        positions = positions % count;
        if (positions == 0) return;

        List<T> temp = new List<T>(list);
        for (int i = 0; i < count; i++)
        {
            list[(i + positions) % count] = temp[i];
        }
    }
}

// ==========================
// Program class with Main
// ==========================
class Program
{
    static void Main(string[] args)
    {
        // Call the MultiplesOf function
        double[] result = Arrays.MultiplesOf(7, 5);

        // Print the output to the terminal
        foreach (double num in result)
        {
            Console.WriteLine(num);
        }
    }
}