using System;

public class Program
{
    static void Main(string[] args)
    {

        var number = Sum(5);
        Console.WriteLine(number);

         int Sum(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            else
            {
                return (n + Sum(n-1));
            }
        }
        
    }
}