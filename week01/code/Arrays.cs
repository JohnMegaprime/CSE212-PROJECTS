using System.Diagnostics;

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
        // ---- PLAN AND EXPLANATION ----
        //1 - I will create an internal array to store the multiples, with the number of indexes based on the length
        //2 - Then I will set a variable to store the multiple value (n)
        //3 - I will write a for loop that will happen the number of times equal to the length
        //4 - Then inside this for loop, I will make a process that multiplies the number by the "i" value or index
        //5 - this "i" value will change at each loop, and the operation will sum i+1 to get the actual number I need to multiply
        //at the end of the loop process, it will store the n value which is the multiple, inside the correct index
        //in the "multiples" array, taking the i value to find it.

        double[] multiples = new double[length];
        
        double n = 0;

        for (int i = 0; i < length; i++)
        {
            n = number * (i+1); 
            multiples[i] = n;
        }

        Debug.WriteLine(multiples);

        return multiples;// replace this return statement with your own
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
        // ---- PLAN AND EXPLANATION ----
        //1 - I will create a list of integers called numbers
        //2 - Then I will calculate the start index based on the data count minus the amount
        //3 - I will create a slice list to store the range of data starting from that index
        //4 - After that, I will remove that same range from the original data list
        //5 - Finally, I will write a for loop that will run the number of times equal to amount
        //at each loop, it will insert the value from slice into the data list at the current i index
        
        List<int> numbers = new List<int>();
            int index = (data.Count()) - amount;

            List<int> slice = data.GetRange(index, amount);
            data.RemoveRange(index, amount);

            for (int i = 0; i < amount; i++)
            {
                data.Insert(i, slice[i]);
            }


    }
}
