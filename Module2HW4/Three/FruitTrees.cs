namespace Module2HW4
{
    public class FruitTrees : DeciduousTree
    {
        public FruitTrees(string name, double height, int age, double trunkDiameter, string fruitType)
            : base(name, height, age, trunkDiameter)
        {
            FruitType = fruitType;
        }

        public string FruitType { get; }
    }
}
