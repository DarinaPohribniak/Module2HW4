namespace Module2HW4
{
    public class Annuals : BloomingFlower
    {
        public Annuals(string name, double height, string vegetationPeriod, double stemLength, string bloomSize, string smell)
         : base(name, height, vegetationPeriod, stemLength, bloomSize)
        {
            Smell = smell;
        }

        public string Smell { get; }
    }
}
