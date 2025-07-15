public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        
        // Plan:
// 1. Create a new array of doubles to store the multiples.
// 2. Loop 'count' times starting from 0.
// 3. On each loop, multiply the starting number by (i + 1).
// 4. Store the result in the array at index i.
// 5. Return the completed array of multiples.

        // Step 1: Create an array of size 'length' to store the result
        double[] multiples = new double[length];

    // Step 2: Loop through the array indices from 0 to length - 1
    for (int i = 0; i < length; i++)
    {
        // Step 3: Calculate each multiple by multiplying the number by (i + 1)
        multiples[i] = number * (i + 1);
    }

    // Step 4: Return the completed array
    return multiples;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        
         // Plan:
    // 1. To rotate the list to the right by 'amount' positions, we need to split it into two parts:
    //    - The last 'amount' elements (these will come to the front after rotation).
    //    - The first part (everything before the last 'amount' elements).
    // 2. We then clear the original list and add these parts back in the new rotated order.


         // Step 1: Use GetRange to slice the list into two parts:
        //         - Right part: the last 'amount' items to be moved to the front
        //         - Left part: the remaining items
        List<int> rightPart = data.GetRange(data.Count - amount, amount);
    List<int> leftPart = data.GetRange(0, data.Count - amount);

    // Step 2: Clear the original list
    data.Clear();

    // Step 3: Add the right part first (rotated portion)
    data.AddRange(rightPart);

    // Step 4: Add the left part (rest of the original list)
    data.AddRange(leftPart);
    }
}
