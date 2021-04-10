namespace ComputerScienceClassImplementationWeaponForPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            Weapon karabmit = new Karabmit("Керамбит", 35);
            Weapon beretta = new Beretta("Беретта", 45, 7);
                
            Hero firstUser = new Hero("Тимофей", 100, beretta);
            Enemy firstEnemy = new Enemy("Hui", 100, karabmit);

            firstUser.Print();
            firstEnemy.Print();

            firstUser.Hit(firstEnemy);
            firstEnemy.Hit(firstUser);
            
            
            firstUser.Print();
            firstEnemy.Print();
        }
    }
}