﻿using System;

namespace ConsoleApp5
{
    public class Shaman : Orc
    {
        public const int MAX_HEALTH = 100;
        public const int MAX_STAMINA = 110;
        public const int STEP_POSITION = 25;
        public const int STAMINA_FOR_ATTACK = 50;
        public const int RESTORE_HEALTH = 35;
        public const int RESTORE_STAMINA = 40;
        public Shaman(float health, int stamina, int armor, int attackDamage, int speed, int position, string orcType)
            : base(health, stamina, armor, attackDamage, speed, position, orcType)
        {
        }
        

        public override void Idle()
        {
            Health += RESTORE_HEALTH;
            PlusStamina();

            if (Health>MAX_HEALTH)
            {
                Health = MAX_HEALTH;
            }

            if (Stamina>MAX_STAMINA)
            {
                Stamina = MAX_STAMINA;
            }
        }

        public override void PlusStamina()
        {
          
            Stamina += RESTORE_STAMINA;
                
        }

        public override void MinusStamina()
        {
            Stamina -= STAMINA_FOR_ATTACK;
        }

        public override void Attack(Orc target)
        {
            if (Stamina < STAMINA_FOR_ATTACK)
            {
                Stamina = 0;
                Console.WriteLine($"Шаман! Восстанови энергию!");
            }
            else
            {
                target.TryApplayDamage(AttackDamage);
                MinusStamina();
            }
        }

        public override void TryApplayDamage(int damage)
        {
            if (Health<=damage-(Armor/5))
            {
                Health = 0;
                Console.WriteLine($"Герой Шаман. Погиб.");
            }
            else
            {
                Health -= damage-(Armor/5);
            }
        }

        public override void MoveForvard()
        {
            Position += STEP_POSITION;
        }

        public override void MoveBack()
        {
            Position -= STEP_POSITION;
        }
    }
}