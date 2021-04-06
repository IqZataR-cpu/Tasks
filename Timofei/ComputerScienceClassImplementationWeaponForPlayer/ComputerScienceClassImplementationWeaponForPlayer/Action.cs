using System;

namespace ComputerScienceClassImplementationWeaponForPlayer
{
    public class Action
    {
        public static void PrintPlayer(Players player)
        {
            Console.WriteLine($"Name: {player.Name}");
            Console.WriteLine($"Health: {player.Health}");
            Console.WriteLine($"Weapon: {player.Weapon.Type}");
            Console.WriteLine($"Damage: {player.Weapon.Damage}");
            Console.WriteLine($"Ammunition: {player.Weapon.Ammunition} \n");
            
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
                if (firstTarget.Weapon is Gun)
                {
                    TryApplyDamage(secondTarget, firstTarget.Weapon.Damage);
                    firstTarget.Weapon.Ammunition -= 1;
                }
                else
                {
                    TryApplyDamage(secondTarget, firstTarget.Weapon.Damage);
                }
            }
        }

        public static void TryApplyDamage(Players target, int damage)
        {
            target.Health -= damage;
        }

        public static void ReloadAmmo(Players target)
        {
            if (target.Weapon is Gun)
            {
                target.Weapon.Reload();
            }
        }

        public static void SwapWeapon(Players target, Weapon weapon)
        {
            target.Weapon = weapon;
        }
    }
}