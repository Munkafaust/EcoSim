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
            //Random array values
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
            //End




            //Collection Initializers
            List<Biome> availableBiomes = new List<Biome>()
            {
                new Biome { Category = "Aquatic", Name = "Coral Reef", ID = 1 },
                new Biome { Category = "Aquatic", Name = "Fresh Water", ID = 2 },
                new Biome { Category = "Aquatic", Name = "Marine", ID = 3 },
                new Biome { Category = "Aquatic", Name = "Pond", ID = 4 },
                new Biome { Category = "Aquatic", Name = "Swamp", ID = 5 },
                new Biome { Category = "Aquatic", Name = "Estuaries", ID = 6 },
                new Biome { Category = "Desert", Name = "Coastal", ID = 7 },
                new Biome { Category = "Desert", Name = "Cold", ID = 8 },
                new Biome { Category = "Desert", Name = "Hot and Dry", ID = 9 },
                new Biome { Category = "Desert", Name = "Semi-Arid", ID = 10 },
                new Biome { Category = "Forest", Name = "Chapparral", ID = 11 },
                new Biome { Category = "Forest", Name = "Coniferous", ID = 12 },
                new Biome { Category = "Forest", Name = "Decidious", ID = 13 },
                new Biome { Category = "Forest", Name = "Rainforest", ID = 14 },
                new Biome { Category = "Forest", Name = "Taiga", ID = 15 },
                new Biome { Category = "Grassland", Name = "Praerie", ID = 16 },
                new Biome { Category = "Grassland", Name = "Temperate", ID = 17 },
                new Biome { Category = "Grassland", Name = "Pampas", ID = 18 },
                new Biome { Category = "Grassland", Name = "Savanna", ID = 19 },
                new Biome { Category = "Grassland", Name = "Steppes", ID = 20 },
                new Biome { Category = "Tundra", Name = "Alpine", ID = 21 },
                new Biome { Category = "Tundra", Name = "Arctic", ID = 22 }
            };
            //End
         
            /*/Object Initializers
            Biome biome1 = new Biome() { Category = "Aquatic", Name = "Coral Reef", ID = 1 };
            Biome biome2 = new Biome() { Category = "Aquatic", Name = "Fresh Water", ID = 2 };
            Biome biome3 = new Biome() { Category = "Aquatic", Name = "Marine", ID = 3 };
            Biome biome4 = new Biome() { Category = "Aquatic", Name = "Pond", ID = 4 };
            Biome biome5 = new Biome() { Category = "Aquatic", Name = "Swamp", ID = 5 };
            Biome biome6 = new Biome() { Category = "Aquatic", Name = "Estuaries", ID = 6 };
            Biome biome7 = new Biome() { Category = "Desert", Name = "Coastal", ID = 7 };
            Biome biome8 = new Biome() { Category = "Desert", Name = "Cold", ID = 8 };
            Biome biome9 = new Biome() { Category = "Desert", Name = "Hot and Dry", ID = 9 };
            Biome biome10 = new Biome() { Category = "Desert", Name = "Semi-Arid", ID = 10 };
            Biome biome11 = new Biome() { Category = "Forest", Name = "Chapparral", ID = 11 };
            Biome biome12 = new Biome() { Category = "Forest", Name = "Coniferous", ID = 12 };
            Biome biome13 = new Biome() { Category = "Forest", Name = "Decidious", ID = 13 };
            Biome biome14 = new Biome() { Category = "Forest", Name = "Rainforest", ID = 14 };
            Biome biome15 = new Biome() { Category = "Forest", Name = "Taiga", ID = 15 };
            Biome biome16 = new Biome() { Category = "Grassland", Name = "Praerie", ID = 16 };
            Biome biome17 = new Biome() { Category = "Grassland", Name = "Temperate", ID = 17 };
            Biome biome18 = new Biome() { Category = "Grassland", Name = "Pampas", ID = 18 };
            Biome biome19 = new Biome() { Category = "Grassland", Name = "Savanna", ID = 19 };
            Biome biome20 = new Biome() { Category = "Grassland", Name = "Steppes", ID = 20 };
            Biome biome21 = new Biome() { Category = "Tundra", Name = "Alpine", ID = 21 };
            Biome biome22 = new Biome() { Category = "Tundra", Name = "Arctic", ID = 22 };
            /*/

        }

        //
        class Biome
        {
            public string Category { get; set; }
            public string Name { get; set; }
            public int ID { get; set; }
        }
        //

        //
        public static int biomeGen(int min, int max, Random bg)
        {
            return bg.Next(min, max);
        }
        //

    }
}
