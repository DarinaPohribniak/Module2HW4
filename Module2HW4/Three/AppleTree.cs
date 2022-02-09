namespace Module2HW4
{
   public class AppleTree : FruitTrees
    {
        public AppleTree(string name, double height, int age, double trunkDiameter, string fruitType, string fruitSize)
            : base(name, height, age, trunkDiameter, fruitType)
        {
            FruitSize = fruitSize;
        }

        public string FruitSize { get; }
    }
}
