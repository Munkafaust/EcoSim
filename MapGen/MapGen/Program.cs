using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
       
        static void Main(string[] args)
        {
        
            int[] regions = new int[7];
            Random random = new Random();

            for (int i = 0; i < regions.Length; i++)
            {
                regions[i] = biomeGen(1,22, random);
            }

            for (int i = 0; i < regions.Length; i++)
            {
                Console.WriteLine(regions[i]);
            }

            Console.ReadLine();
        }

        public static int biomeGen(int min, int max, Random bg)
        {
            return bg.Next(min, max);
        }
        
    }
}
