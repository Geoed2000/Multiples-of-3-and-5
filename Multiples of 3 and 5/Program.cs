using System;
using System.Collections.Generic;

namespace Multiples_of_3_and_5
{
    class Program
    {
        static void Main(string[] args)
        {
            const int Limit = 1000;
            List<int> Numbers = new List<int>();
            int Sum = 0;
            for (int i = 0; i < Limit; i++)
            {
                if (((i % 3) == 0) || ((i % 5) == 0))
                {
                    Numbers.Add(i);
                }
            }
            foreach (int i in Numbers)
            {
                Sum += i;        
            }
            Console.WriteLine("Count = " + Sum);
            Console.ReadLine();
        }
    }
}