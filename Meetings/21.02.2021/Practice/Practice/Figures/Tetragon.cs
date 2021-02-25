using System;

namespace Practice.Figures
{
    public class Tetragon : Figure
    {
        private double AB;
        private double BC;
        private double CD;
        private double DA;
        
        public Tetragon(string name, double ab, double bc, double cd, double da) : base(name)
        {
            AB = ab;
            BC = bc;
            CD = cd;
            DA = da;
        }

        public override double Area2 => Area();
        public double Perimeter => AB + BC + CD + DA;
        public double SemiPerimeter => Perimeter / 2;
        protected override double Area()
        {
            return Math.Sqrt(
                (SemiPerimeter - AB) * 
                (SemiPerimeter - BC) * 
                (SemiPerimeter - CD) * 
                (SemiPerimeter - DA)
            );
        }
        
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Длины сторон:");
            Console.WriteLine($"AB: {AB.ToString()}, BC: {BC.ToString()}, CD: {CD.ToString()}, DA: {DA.ToString()}");
        }
    }
}