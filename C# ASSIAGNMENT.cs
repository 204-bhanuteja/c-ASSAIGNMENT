 Age

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo
{
    internal class age
    {
        static void Main(string[] args)
        {
            Console.Write("Input your current age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Your age after 10 years:");
            age = age + 10;
            Console.Write("{0} ", age);
        }
    }
}


words

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo
{
    internal class words
    {
        public static void Main()
        {
            int a = 0, w = 1;
            string str = "Hello World!";
            while (a <= str.Length - 1)
            {
                if (str[a] == ' ' || str[a] == '\n' || str[a] == '\t')
                {
                    w++;
                }
                a++;
            }
            Console.Write("Number of words in the string = {0}\n", w);
        }
    }
}



finding vowels


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo
{
    internal class vowels
    {
        public static bool isVowel(char ch)
        {
            ch = char.ToUpper(ch);
            return (ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U');
        }

        public static int countVowels(string str)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (isVowel(str[i]))
                {
                    ++count;
                }
            }
            return count;
        }

        public static void Main(string[] args)
        {

            string str = "abcdef";

            Console.WriteLine(countVowels(str));
        }
    }
}



smaller number

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo
{
    internal class Small
    {
        static void Main(string[] args)
        {
            Console.Write("First number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Second number");
            int b = Convert.ToInt32(Console.ReadLine());
            int min;
            if (a < b)
            {
                min = a;
            }
            else
            {
                min = b;
            }
            Console.WriteLine("Small number " + min);
        }
    }
}



new string

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo
{
    internal class newstring
    {
        static void Main(string[] args)
        {
            Console.WriteLine(first_last("Eldin"));
            Console.WriteLine(first_last("mariam"));
            Console.WriteLine(first_last("alex"));
        }
        public static string first_last(string ustr)
        {
            return ustr.Length > 1
                ? ustr.Substring(ustr.Length - 1) + ustr.Substring(1, ustr.Length - 2) + ustr.Substring(0, 1) : ustr;
        }
    }
}




multiplication of three numbers

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo
{
    internal class multiplication
    {
        public static void Main()
        {
            int a, b, c, mult;
            Console.Write("First number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Second number");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Third number");
            c = Convert.ToInt32(Console.ReadLine());
            mult = a * b * c;
            Console.WriteLine("Product of three number" + mult);
        }
    }
}



date

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo
{
    internal class currentdate
    {
        public static void Main()
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            Console.ReadLine();
        }
    }
