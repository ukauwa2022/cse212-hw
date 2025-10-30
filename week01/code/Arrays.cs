using System;
using System.Collections.Generic;

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  
    /// For example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  
    /// Assume that length is a positive integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // PLAN:
        // 1. Create a new array of doubles with size equal to 'length'.
        // 2. Use a for loop to fill the array.
        // 3. Each element in the array should be the number multiplied by (i + 1).
        //    Example: if number = 7 and length = 5 -> array = {7, 14, 21, 28, 35}.
        // 4. Return the filled array.

        // 1. Create an empty array of the required length
        double[] multiples = new double[length];

        // 2. Fill the array with multiples of the number
        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);
        }

        // 3. Return the array
        return multiples;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  
    /// For example, if the data is List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and amount is 3 
    /// then the list after the function runs should be List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  
    /// The value of amount will be in the range 1..data.Count inclusive.
    /// This function modifies the provided list in place (does not return a new list).
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // PLAN:
        // 1. Copy the last 'amount' elements (these will move to the front).
        // 2. Remove those elements from the end of the original list.
        // 3. Insert the copied elements at the beginning of the list.
        // 4. The list is modified in place.

        // Edge cases: if data is null or empty, nothing to do
        if (data == null || data.Count == 0)
        {
            return;
        }

        // If amount is equal to data.Count, the list will look the same after rotation.
        // We can still run the logic below safely, but returning early avoids unnecessary work.
        if (amount % data.Count == 0)
        {
            return;
        }

        // Normalize amount in case it's accidentally larger (defensive)
        amount = amount % data.Count;

        // 1. Copy the last 'amount' elements
        List<int> tail = data.GetRange(data.Count - amount, amount);

        // 2. Remove the last 'amount' elements from the original list
        data.RemoveRange(data.Count - amount, amount);

        // 3. Insert the copied tail elements at the beginning
        data.InsertRange(0, tail);
    }
}
