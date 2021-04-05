using System;

namespace ComputerScienceClassImplementationWeaponForPlayer
{
    public class Action
    {
        public static void PrintPlayer(Players player)
        {
            Console.WriteLine($"Name: {player.Name}");
            Console.WriteLine($"Health: {player.Health}");
            
            if (player.Weapon == "beretta")
            {
                Console.WriteLine($"Weapon: {player.Weapon} " +
                                  $"\nDamage: {player.Damage}" +
                                  $"\nAmmunition: {player.Ammunition} \n");
            }
            else
            {
                Console.WriteLine($"Weapon: {player.Weapon} \n" +
                                  $"Damage: {player.Damage} \n");
        
            }
        }

        public static void Attack(Players firstTarget, Players secondTarget)
        {
            if (firstTarget.Health <= 0)
            {
                firstTarget.Health = 0;
                
                Console.WriteLine("Вы мертвы");
            }
            else if(secondTarget.Health <= 0)
            {
                secondTarget.Health = 0;
                
                Console.WriteLine("Враг мертв.");
            }
            else
            {
                if (firstTarget.Weapon == "beretta")
                {
                    TryApplayDamage(secondTarget, firstTarget.Damage);
                    firstTarget.Ammunition -= 1;
                }
                else
                {
                    TryApplayDamage(secondTarget, firstTarget.Damage);
                }
            }
        }

        public static void TryApplayDamage(Players target, int damage)
        {
            target.Health -= damage;
        }

        public static void ReloadAmmo(Players target)
        {
            if (target.Weapon == "beretta")
            {
                target.Ammunition = 7;
            }
        }

        public static void SwapWeapon(Players target)
        {
            if (target.Weapon == "beretta")
            {
                target.Weapon = "karambit";
                target.Damage = 35;
                target.Ammunition = 0;
            }
            else
            {
                target.Weapon = "beretta";
                target.Damage = 40;
                target.Ammunition = 7;
            }
        }
    }
}