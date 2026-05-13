using System;

public class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9];


        RotateListRight(numbers, 8);

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
        
        static void RotateListRight(List<int> data, int amount)
        {
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
}