               //Average Value
    using System;

class Avg
{
    public static void Main()
    {
        int[] arr = { 1, 2, 6, 2, 18 };

        int i = 0;
        int sum = 0;
        float average = 0.0F;

        for (i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }

        average = (float)sum / arr.Length;

        Console.WriteLine("Average of Array elements: " + average);
    }
}






          //SECONG HIGHEST VALUE IN ARRAY



using System;  
using System.Collections;  
  
public class Program
{
    public static void Main()
    {
        int[] array = { 2, 11, 15, 1, 7, 99, 6, 85, 4 };
        Array.Sort(array); //sorting array  
        Array.Reverse(array); // Reverse Sorting array value  
        Console.WriteLine("Second Highest Value In Array " + array[1]);

        foreach (var result in array)
        {
            Console.Write(result + " "); // Array values   
        }
    }
}
