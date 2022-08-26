               ///CHECKING PRIME

using System;
public class funcexer9
{
    public static bool chkprime(int num)
    {
        for (int i = 2; i < num; i++)
            if (num % i == 0)
                return false;
        return true;
    }
    public static void Main()
    {
        Console.Write("\n\nFunction : To check a number is prime or not :\n");
        Console.Write("--------------------------------------------------\n");
        Console.Write("Input a number : ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (chkprime(n))
            Console.WriteLine(n + " is a prime number");
        else
            Console.WriteLine(n + " is not a prime number");
    }
}





        ///BIGGEST PRIME NUMBER



Using System;

class MyProgram
{
    static long MaxPrime(long num)
    {
        long CurrMaxPrime = -1;

        //If num is divisible by 2, store CurrMaxPrime
        //as 2. keep on dividing num until it is not 
        //divisible by 2. After each division, update 
        //num as num/2.
        if (num % 2 == 0)
        {
            CurrMaxPrime = 2;
            while (num % 2 == 0)
            {
                num = num / 2;
            }
        }

        //At this point, num must be odd. Starting with 
        //3 to square root of num , if divisible, divide 
        //and update num, and update CurrMaxPrime
        for (long i = 3; i <= Math.Sqrt(num); i += 2)
        {
            while (num % i == 0)
            {
                CurrMaxPrime = i;
                num = num / i;
            }
        }

        //if the modified num is greater than 2, 
        //update the CurrMaxPrime with num 
        if (num > 2)
            CurrMaxPrime = num;

        return CurrMaxPrime;
    }

    static void Main(string[] args)
    {
        long x, y, z;
        x = 42;
        y = 1092;
        z = 695467363456;

        Console.WriteLine("Largest prime factor of " + x
                           + " is: " + MaxPrime(x));
        Console.WriteLine("Largest prime factor of " + y
                           + " is: " + MaxPrime(y));
        Console.WriteLine("Largest prime factor of " + z
                           + " is: " + MaxPrime(z));
    }
}
