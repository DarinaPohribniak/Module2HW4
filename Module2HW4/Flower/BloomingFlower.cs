namespace Module2HW4
{
   public class BloomingFlower : NonCurlyFlower
    {
        public BloomingFlower(string name, double height, string vegetationPeriod, double stemLength, string inflorescenceSize)
          : base(name, height, vegetationPeriod, stemLength)
        {
            InflorescenceSize = inflorescenceSize;
        }

        public string InflorescenceSize { get; }
    }
}
