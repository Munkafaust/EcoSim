using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearningSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            //Biome list initilization
            List<Biome> availableBiomes = Biome.setBiomes();
            //

            //Creating game Tiles
            List<Tile> randomSeven = new List<Tile>();
            Random random = new Random();
            for (int i = 0; i < 7; i++)
            {
                int randomID = getRandom(1, 22, random);
                randomSeven.Add(new Tile { Biome = availableBiomes.Single(x => x.ID == randomID), Location = i });
            }
            //

            //Printing Tile information
            foreach (var tile in randomSeven)
            {
                Console.WriteLine("{0} - {1} - {2} ({3})", tile.Location, tile.Biome.Category, tile.Biome.Name, tile.Biome.ID);
            }
            Console.ReadLine();
            //

        }

        public static int getRandom(int min, int max, Random random)
        {
            return random.Next(min, max);
        }

        class Biome
        {
            public string Category { get; set; }
            public string Name { get; set; }
            public int ID { get; set; }
            public static List<Biome> setBiomes()
            {
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
            return availableBiomes;
            }
        }

        class Tile
        {
            public Biome Biome { get; set; }
            public int Location { get; set; }
        }
    }
}
