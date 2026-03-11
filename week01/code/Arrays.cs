using System;
using System.Collections.Generic;

public static class Arrays
{
    /// <summary>
    /// Returns an array containing the first 'length' multiples of 'number'.
    /// Handles zero, negative numbers, and non-positive length.
    /// </summary>
    public static double[] MultiplesOf(double number, int length)
    {
        if (length <= 0)
            return new double[0];  // return empty array for non-positive length

        double[] result = new double[length];
        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }
        return result;
    }

    /// <summary>
    /// Rotates a list to the right by 'positions'.
    /// Handles negative positions and rotations greater than list length.
    /// Works in-place using the 3-reverse algorithm.
    /// </summary>
    public static void RotateListRight<T>(List<T> list, int positions)
    {
        if (list == null || list.Count <= 1 || positions == 0)
            return;

        int count = list.Count;
        positions = ((positions % count) + count) % count; // normalize rotations

        // Reverse the entire list
        list.Reverse(0, count);

        // Reverse the first 'positions' elements
        list.Reverse(0, positions);

        // Reverse the remaining elements
        list.Reverse(positions, count - positions);
    }
}