using System;

namespace Module2HW4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // create plants
            Plant[] plants = new Plant[11];
            plants[0] = new Perennials(name: "RoseNew", height: 50, vegetationPeriod: "long", stemLength: 45, bloomSize: "big", color: "red");
            plants[1] = new Perennials(name: "Rose", height: 52, vegetationPeriod: "long", stemLength: 45, bloomSize: "big", color: "white");
            plants[2] = new Perennials(name: "Peony", height: 43, vegetationPeriod: "long", stemLength: 35, bloomSize: "big", color: "red");
            plants[3] = new Perennials(name: "Lily", height: 35, vegetationPeriod: "long", stemLength: 35, bloomSize: "big", color: "yellow");
            plants[4] = new Annuals(name: "Aster", height: 15, vegetationPeriod: "short", stemLength: 14, bloomSize: "small", smell: "average");
            plants[5] = new Annuals(name: "Calendula", height: 12, vegetationPeriod: "short", stemLength: 11, bloomSize: "small", smell: "weak");
            plants[6] = new Annuals(name: "Petunia", height: 14, vegetationPeriod: "short", stemLength: 13, bloomSize: "small", smell: "average");
            plants[7] = new AppleTree(name: "Golden", height: 180, age: 5, trunkDiameter: 20, fruitType: "sweet", fruitSize: "big");
            plants[8] = new AppleTree(name: "BlackPrince", height: 185, age: 5, trunkDiameter: 26, fruitType: "sweet", fruitSize: "big");
            plants[9] = new Cherry(name: "Toy", height: 150, age: 6, trunkDiameter: 15, fruitType: "sweet", fruitColor: "red");
            plants[10] = new Cherry(name: "Night", height: 170, age: 6, trunkDiameter: 16, fruitType: "sweet", fruitColor: "red");

            // make make a garden fence
            Area area = new Area(plants);
            Console.WriteLine("There are many plants in the area:");
            foreach (var plant in plants)
            {
                plant.Print();
            }

            Console.WriteLine();

            // Types of plant count
            Console.WriteLine("Determination of the total number of plant species in the garden.");
            area.GetTypePlantCount();
            Console.WriteLine();

            // Plants sort
            Console.WriteLine("Sort plants in the garden by name:");
            Array.Sort(plants);
            foreach (Plant plant in plants)
            {
                Console.WriteLine($"{plant.Name} - {plant.Height} cm.");
            }

            Console.WriteLine();

            // Plant search result by criterion
            Console.WriteLine("Search for a plant of a given height.");
            plants.IsPlantHeigh(150);
            Console.ReadLine();
        }
    }
}
