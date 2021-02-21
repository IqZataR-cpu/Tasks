using System;

namespace Practice.Figures
{
    public class Tetragon : Figure
    {
        private int AB;
        private int BC;
        private int CD;
        private int DA;
        
        public Tetragon(string name, int ab, int bc, int cd, int da) : base(name)
        {
            AB = ab;
            BC = bc;
            CD = cd;
            DA = da;
        }

        public override double Area2 => Area();
        public int Perimeter => (AB + BC + CD + DA);
        public int SemiPerimeter => Perimeter / 2;
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