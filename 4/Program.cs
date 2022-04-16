using System;
using System.Collections.Generic;

class General
{
    public static void Main(String[] args)
    {   // reqemleri cemi 11 den boyuk, 11-e bolunen 11-ci eded


        int maxLimit = 1000;
        bool flag = true;
        int count = 0;
        //99
        for (int i = 1; i <= maxLimit; i++)
        {
            if (i % 11 == 0)
            {
                int cem = 0;
                int ededCopy = i;
                while (ededCopy > 0)
                {
                    cem = cem + ededCopy % 10;
                    ededCopy = ededCopy / 10;
                }


                if (cem >= 11)
                {

                    count++;
                    if (count == 11)
                    {
                        Console.WriteLine(i);

                    }

                }
            }
        }
    }
}