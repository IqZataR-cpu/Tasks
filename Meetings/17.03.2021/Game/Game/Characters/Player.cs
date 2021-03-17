using Game.CharacterClasses;
using Game.Races;

namespace Game.Characters
{
    public class Player : Character 
    {
        public Player(CharacterClass characterClass, Race race) : base(characterClass, race) { }
    }
}