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

            for (int i = 0; i < regions.Length; i++)
            {
                Random random = new Random();
                System.Threading.Thread.Sleep(50);
                regions[i] = random.Next(1, 22);
                //Console.WriteLine(regions[i]);
            }


            for (int i = 0; i < regions.Length; i++)
            {
                Console.WriteLine(regions[i]);

            }

            Console.ReadLine();

        }

        public static int biomeGen(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        
    }
}
