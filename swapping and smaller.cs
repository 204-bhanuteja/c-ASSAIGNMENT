using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System;
public class swapping
{
    public static void Swap(ref int a, ref int b)
    {
        a = a * b;
        b = a / b;
        a = a / b;
    }
    public static void Main(string[] args)
    {
        int a = 5, b = 10;
        Console.WriteLine($" Before swap a={a} b={b}");
        Swap(ref a, ref b);
        Console.WriteLine($" Before swap a={a} b={b}");
    }
}


       //smaller number



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class smallest
    {


        public static void getsmaller(int a, int b, out int res)
        {
            if (a < b)
            {
                res = a;
            }
            else
            {
                res = b;

            }

        }
        public static void Main()
        {
            Console.WriteLine("enter the value of a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value of b");
            int b = Convert.ToInt32(Console.ReadLine());
            getsmaller(a, b, out int res);
            Console.WriteLine($"{res} is smaller");
        }
    }
}