namespace ObjectOrientiedProgramming
{
    //
    // Создать базовый класс Human
    // Общие поля: здоровье, скорость,
    // атака(количество наносимого урона),
    // броня(когда получает урон, Здоровье = Здоровье - (атака - 10% от брони)),
    // местоположение(линейное движение от 0 и далее)
    //
    // Базовые методы: Отдых, Атака, Движение, Получение урона
    //
    // Создать подклассы: Warrior, Archer.
    // Реализовать базовые методы для подтипов.
    //
    // Создать небольшое взаимодействие между несколькими объектами,
    // без консольного выбора 
    //
    class Program
    {
        static void Main(string[] args)
        {
            Human warrior = new Warrior("Артем",100, 5, 10, 1);
            Human archer = new Archer("Миша", 100, 5, 10, 1);

            warrior.Print();
            archer.Print();
            
            warrior.Attack(archer);
            archer.Attack(warrior);
            
            warrior.Print();
            archer.Print();
            
            warrior.MoveBack();
            archer.MoveForward();
            warrior.Idle();
            archer.Idle();
            
            warrior.Print();
            archer.Print();
        }
    }
}