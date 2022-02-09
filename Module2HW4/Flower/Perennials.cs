namespace Module2HW4
{
    public class Perennials : BloomingFlower
    {
        public Perennials(string name, double height, string vegetationPeriod, double stemLength, string bloomSize, string color)
 : base(name, height, vegetationPeriod, stemLength, bloomSize)
        {
            Color = color;
        }

        public string Color { get; }
    }
}
