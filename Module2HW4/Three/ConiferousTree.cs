namespace Module2HW4
{
    public class ConiferousTree : Three
    {
        public ConiferousTree(string name, double height, int age, double needlesLength)
            : base(name, height, age)
        {
            NeedlesLength = needlesLength;
        }

        public double NeedlesLength { get; }
    }
}
