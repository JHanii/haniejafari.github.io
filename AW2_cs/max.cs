using System;

namespace AW2_cs
{
    class max
    {
            static int maxi(params int [] a)
            {
                int m = a[0];
                foreach (int item in a)
                {
                    if(item > m)    m = item;
                }
                    return m;
            }
        static void Main(string[] args)
        {
            Console.WriteLine(maxi(1, 5, 8, 3));
        }
    }
}
