using System;

namespace Module2HW4
{
    public abstract class Plant : IComparable<Plant>
    {
        public Plant(string name, double height)
        {
            Name = name;
            Height = height;
        }

        public string Name { get; }
        public double Height { get; }

        public int CompareTo(Plant other)
        {
            if (other is null)
            {
                throw new ArgumentException("Сan't compare");
            }

            return Name.CompareTo(other.Name);
        }
    }
}
