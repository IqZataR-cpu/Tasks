namespace Game.Races
{
    public class Orc : Race
    { 
        private const double HealthRate = 1.2;

        public Orc(): base(HealthRate) { }
    }
}