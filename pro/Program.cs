using System;

namespace Example//123456789
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1
            //long a = Convert.ToInt32(Console.ReadLine());
            //if (a < 10000000000 && a < 1000000000)
            //{
            //    while (a > 0)
            //    {
            //        string l = Convert.ToString(a);
            //        if ((l.Length) % 2 != 0)
            //        {                        
            //            string num = Convert.ToString(a % 10);
            //            Console.Write(num);
            //        }
            //        a = a / 10;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Exception founded");
            //}
            #endregion
            int number = Int32.Parse(Console.ReadLine());
            int check = Check(number);
            double swap = Swap(check);
            int odd = Odd((int)swap);
            Console.WriteLine($"Checked number is {check}\n" +
                $"First and last digits swaped number is {swap}\n" +
                $"The count of odd digits id {odd}");
        }
        public static int Check(int num)
        {
            int rem, newNum = 0;
            int floor = 1;
            while (num > 0)
            {
                rem = num % 10;

                if (rem != 5 && rem != 7)
                {
                    newNum = newNum + rem * floor;
                    floor *= 10;
                }
                num = num / 10;
            }
            return newNum;
        }
        public static double Swap(int num)
        {
            int first, last, count, temp = 0;
            double swap;
            temp = num;
            last = num % 10;
            count = (int)Math.Log10(temp);
            while (temp >= 10)
            {
                temp /= 10;
            }
            first = temp;
            swap = (last * Math.Pow(10, count) + first) + (num - (first * Math.Pow(10, count) + last));
            return swap;
        }
        public static int Odd(int num)
        {
            int count = 0;
            while (num > 0)
            {
                if ((num % 10) % 2 != 0)
                {
                    count++;
                }
                num /= 10;
            }
            return count;
        }
    }
}