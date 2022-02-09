namespace Module2HW4
{
    public class BarrenTree : DeciduousTree
    {
        public BarrenTree(string name, double height, int age, double trunkDiameter, string crownDensity)
           : base(name, height, age, trunkDiameter)
        {
            CrownDensity = crownDensity;
        }

        public string CrownDensity { get; }
    }
}
