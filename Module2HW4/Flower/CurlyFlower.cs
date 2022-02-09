namespace Module2HW4
{
    public class CurlyFlower : Flower
    {
        public CurlyFlower(string name, double height, string vegetationPeriod, string needForLighting)
           : base(name, height, vegetationPeriod)
        {
            NeedForLighting = needForLighting;
        }

        public string NeedForLighting { get; }
    }
}
