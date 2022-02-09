namespace Module2HW4
{
    public class Cherry : FruitTrees
    {
        public Cherry(string name, double height, int age, double trunkDiameter, string fruitType, string fruitColor)
             : base(name, height, age, trunkDiameter, fruitType)
        {
            FruitColor = fruitColor;
        }

        public string FruitColor { get; }
    }
}
