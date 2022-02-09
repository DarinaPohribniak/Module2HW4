namespace Module2HW4
{
    public class NonCurlyFlower : Flower
    {
        public NonCurlyFlower(string name, double height, string vegetationPeriod, double stemLength)
          : base(name, height, vegetationPeriod)
        {
            StemLength = stemLength;
        }

        public double StemLength { get; }
    }
}
