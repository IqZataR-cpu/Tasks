using System;
using System.Security.Cryptography;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Сделай переносы, не нужно писать код одной строкой, это не ВБА!!! Пример покажу на будущее -> ниже как правильно.
            Worker[] Workers = new Worker[] {
                new Worker("Михаил", "Будяков", 3000, 20),
                // не выделил знаки пробелами
                new Worker("Александр","Куншин",1500,20),
                new Worker("Лихачев","Артем",1000,10)
            };

            Console.WriteLine("Все работники: "); // Можно отделить enter, субъективно
            for (int i = 0; i < Workers.Length; i++)
            {
                // не выделил знаки пробелами
                Console.WriteLine($"Работник{i+1}: ");
                Workers[i].ShowWorkers();
                Console.WriteLine("\n");
            }
            
            Console.Write("Введите номер работника, по которому нужна информация: ");
            // Почему не int.Parse(), тебе действительно нужен для этой операции целый класс Convert?
            int numberWorker = Convert.ToInt32(Console.ReadLine());
            // не выделил знаки пробелами
            Workers[numberWorker-1].Salary();
        }
        
    }
    class Worker
    {
        public string Name;
        public string Surname;
        public int Rate;
        public int Days;

        public Worker(string name, string surname, int rate, int days)
        {
            Name = name;
            Surname = surname;
            Rate = rate;
            Days = days;
        }

        // Не корректное название метода, логично было бы назвать Info или Show,
        // по названию класса и так понятно что это Worker.
        // Но самое главное почему WorkerSSS, а не Worker,
        // ты же инфу только по одному выводишь за один вызов метода.
        public void ShowWorkers()
        {
            // Лучше \n выделить enter, и использовать интерполяцию строк, пример ниже
            Console.Write(
                $"Имя работника = { Name } \n" +
                $"Фамилия = { Surname } \n" +
                $"Ставка в день = { Rate } \n" +
                $"Количество дней = { Days }"
            );
        }

        public void Salary()
        {
            // Лишнее место в памяти, 
            // по названию метода и так понятно что будет выведено,
            // поэтому просто в консоль выводим Rate * Days, вместо Salary
            int Salary = Rate * Days;
            Console.WriteLine($"Зарплата данного работника составляет: {Salary}");
        }
    }
}
