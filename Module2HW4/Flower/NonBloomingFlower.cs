namespace Module2HW4
{
    public class NonBloomingFlower : NonCurlyFlower
    {
        public NonBloomingFlower(string name, double height, string vegetationPeriod, double stemLength, string needWatering)
          : base(name, height, vegetationPeriod, stemLength)
        {
            NeedWatering = needWatering;
        }

        public string NeedWatering { get; }
    }
}
