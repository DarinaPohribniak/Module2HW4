using System;

namespace Module2HW4
{
    public class Area : IArea
    {
        public Area(Plant[] plants)
        {
            if (plants == null)
            {
                plants = new Plant[0];
            }
            else
            {
                Plants = plants;
            }
        }

        private Plant[] Plants { get; }

        public void GetTypePlantCount()
        {
            int count = 0;
            int j = 0;
            for (int i = 0; i < Plants.Length; i++)
            {
                var plantType = Plants[i].GetType();
                if (Plants[j].GetType() == plantType)
                {
                    count++;
                }
            }

            Console.WriteLine($"Total count of type plants is {count} units.");
        }
    }
}
