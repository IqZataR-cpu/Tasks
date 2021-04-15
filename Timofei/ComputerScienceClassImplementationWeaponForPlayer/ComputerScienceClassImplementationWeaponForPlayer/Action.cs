using System;

namespace ComputerScienceClassImplementationWeaponForPlayer
{
    public class Action
    {
        // public static void Attack(Players firstTarget, Players secondTarget)
        // {
        //     if (firstTarget.Health <= 0)
        //     {
        //         firstTarget.Health = 0;
        //         
        //         Console.WriteLine("Вы мертвы");
        //     }
        //     else if(secondTarget.Health <= 0)
        //     {
        //         secondTarget.Health = 0;
        //         
        //         Console.WriteLine("Враг мертв.");
        //     }
        //     else
        //     {
        //         if (firstTarget.Weapon is Weapon)
        //         {
        //             TryApplyDamage(secondTarget, firstTarget.Weapon.Damage);
        //             firstTarget.Weapon.Ammunition -= 1;
        //         }
        //         else
        //         {
        //             TryApplyDamage(secondTarget, firstTarget.Weapon.Damage);
        //         }
        //     }
        // }
        //
        // public static void TryApplyDamage(Players target, int damage)
        // {
        //     target.Health -= damage;
        // }
        //
        // public static void ReloadAmmo(Players target)
        // {
        //     if (target.Weapon is Weapon)
        //     {
        //         target.Weapon.Reload();
        //     }
        // }
        //
        // public static void SwapWeapon(Players target, Weapon weapon)
        // {
        //     target.Weapon = weapon;
        // }
    }
}