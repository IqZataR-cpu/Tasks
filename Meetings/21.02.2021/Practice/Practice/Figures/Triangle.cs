using System;

namespace Practice.Figures
{
    public class Triangle : Figure
    {
        private int AB;
        private int AC;
        private int BC;
        
        public Triangle(string name, int ab, int ac, int bc) : base(name)
        {
            AB = ab;
            AC = ac;
            BC = bc;
        }

        public override double Area2 => Area();
        public int Perimeter => (AB + AC + BC);
        public int SemiPerimeter => Perimeter / 2;

        protected override double Area()
        {
            return SemiPerimeter * (SemiPerimeter - AB) * (SemiPerimeter - AC) * (SemiPerimeter - BC);
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Длины сторон:");
            Console.WriteLine($"AB: {AB.ToString()}, AC: {AC.ToString()}, BC: {BC.ToString()}");
        }
    }
}