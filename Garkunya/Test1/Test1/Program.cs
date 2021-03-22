using System;
using System.Security.Cryptography;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker[] Workers = new Worker[] {
            new Worker("Михаил", "Будяков", 3000, 20),
            new Worker("Александр", "Куншин", 1500, 20),
            new Worker("Лихачев", "Артем", 1000, 10)};

            Console.WriteLine("Все работники: ");
            
            for (int i = 0; i < Workers.Length; i++)
            {
                Console.WriteLine($"Работник{ i + 1 }: ");
                Workers[i].Show();
                Console.WriteLine("\n");
            }
            
            Console.Write("Введите номер работника, по которому нужна информация: ");
            int numberWorker = int.Parse(Console.ReadLine());
            Workers[numberWorker - 1].Salary();
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

        public void Show()
        {
            Console.Write(
                $"Имя работника = { Name } \n" +
                $"Фамилия = { Surname } \n" +
                $"Ставка в день = { Rate } \n" +
                $"Количество дней = { Days }"
            );
        }

        public void Salary()
        {
            Console.WriteLine($"Зарплата данного работника составляет: { Rate * Days }");
        }
    }
}
