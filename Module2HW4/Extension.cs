using System;

namespace Module2HW4
{
    public static class Extension
    {
        public static void IsPlantHeigh(this Plant[] plants, double heihgt)
        {
            for (int i = 0; i < plants.Length; i++)
            {
                if (plants[i].Height == heihgt)
                {
                    plants[i].Print();
                    break;
                }
            }
        }

        public static void Print(this Plant plant)
        {
            Console.WriteLine($"Plant: {plant.Name}; height: {plant.Height} cm.");
        }
    }
}
