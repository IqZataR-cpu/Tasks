namespace ComputerScienceClassImplementationWeaponForPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            Knife knife = new Knife("knife", 35, 0);
            Gun pistol = new Gun("gun", 40, 7);
            
            Hero firstUser = new Hero("Тимофей", 100, knife);
            Enemy firstEnemy = new Enemy("Hui", 100, pistol);

            Action.PrintPlayer(firstUser);
            Action.PrintPlayer(firstEnemy);
            
            Action.SwapWeapon(firstUser, pistol);
           
            Action.PrintPlayer(firstUser);
            Action.PrintPlayer(firstUser);
            
            Action.SwapWeapon(firstUser, knife);
            
            Action.PrintPlayer(firstUser);
            
            Action.Attack(firstEnemy, firstUser);
            
            Action.PrintPlayer(firstUser);
            Action.PrintPlayer(firstEnemy);
            
            Action.ReloadAmmo(firstEnemy);
            Action.PrintPlayer(firstEnemy);
        }
    }
}