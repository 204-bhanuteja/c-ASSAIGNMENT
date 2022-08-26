     //COPY THE ELEMENTS FROM ONE ARRAY TO NEW ARRAY

using System;
public class Exercise4
{
    public static void Main()
    {
        int[] arr1 = new int[100];
        int[] arr2 = new int[100];
        int i, n;


        Console.Write("\n\nCopy the elements one array into another array :\n");
        Console.Write("----------------------------------------------------\n");

        Console.Write("Input the number of elements to be stored in the array :");
        n = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input {0} elements in the array :\n", n);
        for (i = 0; i < n; i++)
        {
            Console.Write("element - {0} : ", i);
            arr1[i] = Convert.ToInt32(Console.ReadLine());
        }
        /* Copy elements of first array into second array.*/
        for (i = 0; i < n; i++)
        {
            arr2[i] = arr1[i];
        }


        /* Prints the elements of first array   */
        Console.Write("\nThe elements stored in the first array are :\n");
        for (i = 0; i < n; i++)
        {
            Console.Write("{0}  ", arr1[i]);
        }


        /* Prints the elements copied into the second array. */
        Console.Write("\n\nThe elements copied into the second array are :\n");
        for (i = 0; i < n; i++)
        {
            Console.Write("{0}  ", arr2[i]);
        }
        Console.Write("\n\n");
    }
}

MERGE TWO SORTED ARRAYS




using System;
using System.Collections.Generic;
 
class Program
{
    static void Main()
    {
        int i = 0;
        int j = 0;

        int[] arr1 = new int[5] {
         5,
         15,
         25,
         30,
         47
      };
        int[] arr2 = new int[5] {
         55,
         60,
         76,
         83,
         95
      };
        int[] merged = new int[10];

        for (i = 0, j = 0; i < 5; i++)
        {
            merged[j++] = arr1[i];
        }
        for (i = 0; i < 5; i++)
        {
            merged[j++] = arr2[i];
        }
        Console.WriteLine("Elements of merged array = ");
        for (i = 0; i < 10; i++)
        {
            Console.WriteLine("merged[" + (i) + "]: " + merged[i]);
        }
        Console.WriteLine();
    }
}
