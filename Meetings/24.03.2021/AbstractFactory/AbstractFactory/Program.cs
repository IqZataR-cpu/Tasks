using System;

namespace AbstractFactory
{
    // Описание:
    // У нас есть класс герой, в нем есть различные способы перемещения и использования оружия.
    // Способы и оружие перечислены в enum.
    // Задание: 
    // 1. Переделать enum в абстрактные классы Movement и Weapon с соответствующими подтипами
    // Для Movement - Run, Fly.
    // Для Weapon - Sword, Knife, Riffle.
    // 2. Поменять в классе Hero приватные переменные на новые типы.
    // 3. Создать несколько комбинаций оружия и передвижений в герое.
    // Пример: Бегающий герой с ножом, Летающий герой с ружьем и тд.
    //
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    class Hero
    {
        private Weapon _weapon;
        private Movement _movement;

        public enum Weapon
        {
            Sword,
            Knife,
            Riffle
        }

        public enum Movement
        {
            Run,
            Fly
        }
        
        public Hero(Weapon weapon, Movement movement)
        {
            _weapon = weapon;
            _movement = movement;
        }

        public void Move()
        {
            switch (_movement)
            {
                case Movement.Fly:
                    Console.WriteLine("Вы летите");
                    break; 
                case Movement.Run:
                    Console.WriteLine("Вы бежите");
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public void Hit()
        {
            switch (_weapon)
            {
                case Weapon.Sword:
                    Console.WriteLine("Вы ударили мечом");
                    break; 
                case Weapon.Knife:
                    Console.WriteLine("Вы ударили ножом");
                    break;  
                case Weapon.Riffle:
                    Console.WriteLine("Вы выстрелили из ружбая");
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}