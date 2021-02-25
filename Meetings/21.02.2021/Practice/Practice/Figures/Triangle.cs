using System;

namespace Practice.Figures
{
    public class Triangle : Figure
    {
        private double AB;
        private double AC;
        private double BC;
        
        public override double Area2 => Area();
        public double Perimeter => AB + AC + BC;
        public double SemiPerimeter => Perimeter / 2;
        
        public Triangle(string name, double ab, double ac, double bc) : base(name)
        {
            AB = ab;
            AC = ac;
            BC = bc;
        }

        protected override double Area()
        {
            return SemiPerimeter * 
                   (SemiPerimeter - AB) *
                   (SemiPerimeter - AC) * 
                   (SemiPerimeter - BC);
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Длины сторон:");
            Console.WriteLine($"AB: {AB.ToString()}, AC: {AC.ToString()}, BC: {BC.ToString()}");
        }
    }
}