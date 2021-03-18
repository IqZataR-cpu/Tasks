using System;
using Game.CharacterClasses;
using Game.Races;

namespace Game.Characters
{
    public abstract class Character
    {
        private readonly Race _race;
        private readonly CharacterClass _characterClass;

        private int _maxHealth;
        private int _currentHealth;

        private int _attackDamage;
        
        protected Character(CharacterClass characterClass, Race race)
        {
            _characterClass = characterClass;
            _race = race;
            SetStates();
        }

        public void PrintStates()
        {
            Console.WriteLine($"MaxHealth = {_maxHealth} \n" +
                              $"CurrentHealth = {_currentHealth} \n");
        }
        
        public virtual void Attack(Character character)
        {
            character.ApplyDamage(_attackDamage);
        }

        private void ApplyDamage(int damage)
        {
            if (_currentHealth > damage)
            {
                _currentHealth -= damage;
            }
            else
            {
                _currentHealth = 0;
            }
        }
        
        private void SetStates()
        {
            CalculateMaxHealth();
            CalculateAttackDamage();
            _currentHealth = _maxHealth;
        }

        private void CalculateAttackDamage()
        {
            _attackDamage = _characterClass.AttackDamage;
        }

        private void CalculateMaxHealth()
        {
            _maxHealth = (int) Math.Round(_characterClass.Health * _race.HealthRate);
        }
    }
}