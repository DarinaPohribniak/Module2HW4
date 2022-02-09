namespace Module2HW4
{
    public class DeciduousTree : Three
    {
        public DeciduousTree(string name, double height, int age, double trunkDiameter)
            : base(name, height, age)
        {
            TrunkDiameter = trunkDiameter;
        }

        public double TrunkDiameter { get; }
    }
}
