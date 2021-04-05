﻿namespace ComputerScienceClassImplementationWeaponForPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            Knife knife = new Knife("karambit", 35, 0);
            Gun pistol = new Gun("beretta", 40, 7);
            
            Hero firstUser = new Hero("Тимофей", 100, pistol.Type, pistol.Damage, pistol.Ammunition);
            Enemy firstEnemy = new Enemy("Hui", 100, knife.Type, knife.Damage, knife.Ammunition);

            Action.PrintPlayer(firstUser);
         
            Action.SwapWeapon(firstUser);
            
            Action.PrintPlayer(firstUser);
            
            Action.SwapWeapon(firstEnemy);
            
            Action.PrintPlayer(firstEnemy);
            
            Action.Attack(firstEnemy, firstUser);
            Action.Attack(firstEnemy, firstUser);
            Action.Attack(firstEnemy, firstUser);
            Action.Attack(firstEnemy, firstUser);
            Action.Attack(firstUser, firstEnemy);
            Action.Attack(firstUser, firstEnemy);
  
            
            Action.PrintPlayer(firstUser);
            Action.PrintPlayer(firstEnemy);
        }
    }
}