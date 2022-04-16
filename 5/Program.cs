using System;

namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int copy = a;
            int reverse = 0;
            int qaliq;
            int b = 1;
            int x = int.Parse(b.ToString() + a.ToString() + b.ToString());
            while (a > 0)
            { /// 13  
                qaliq = a % 10;
                reverse = reverse * 10 + qaliq;
                a /= 10;
            }
            Console.WriteLine($"bu ededin tersi{reverse} ");
            if (reverse == copy)
            {

                Console.WriteLine(x);
            }
            else
            {
                Console.WriteLine(copy);
            }



        }

    }
}
