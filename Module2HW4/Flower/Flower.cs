namespace Module2HW4
{
    public class Flower : Plant
    {
        public Flower(string name, double height, string vegetationPeriod)
           : base(name, height)
        {
            VegetationPeriod = vegetationPeriod;
        }

        public string VegetationPeriod { get; }
            }
}
