namespace Module2HW4
{
    public class Three : Plant
    {
        public Three(string name, double height, int age)
            : base(name, height)
        {
            Age = age;
        }

        public int Age { get; }
    }
}
