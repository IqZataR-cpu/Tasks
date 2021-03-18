using System;
using Game.CharacterClasses;
using Game.Races;

namespace Game.Characters
{
    public class NPC : Character
    {
        private bool _isFriendly;
        
        public NPC(CharacterClass characterClass, Race race, bool isFriendly) : base(characterClass, race)
        {
            _isFriendly = isFriendly;
        }
        
        public override void Attack(Character character)
        {
            if (character is Player && _isFriendly)
            {
                Console.WriteLine("Грубо не атакуем друга!!!FUCK MOY MOZG!!!");
            }
            else
            {
                base.Attack(character);
            }
        }
    }
}