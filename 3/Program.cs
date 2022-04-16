using System;

class General
{
    public static void Main(String[] args)
    {
        int maxLimit = 1000;
        for (int i = 1; i <= maxLimit; i++)
        {
            bool flag = true;
            // eyni eded testi
            string number = i.ToString();
            for (int j = 0; j < number.Length; j++)
            {
                if (number[j / number.Length] != number[number.Length - j - 1])
                {
                    flag = false;
                    break;
                }
            }

            // 5 olmasin
            if (number.Contains('5'))
            {
                flag = false;
            }

            // Reqemlerin cemi
            int cem = 0;
            int ededCopy = i;
            while (ededCopy > 0)
            {
                cem = cem + ededCopy % 10;
                ededCopy = ededCopy / 10;
            }

            if (cem <= 5)
            {
                flag = false;
            }

            // Cap etme
            if (flag == true)
            {
                Console.WriteLine(i);
            }
        }
    }
}