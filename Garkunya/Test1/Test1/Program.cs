using System;
using System.Security.Cryptography;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker[] Workers = new Worker[] {new Worker("Михаил", "Будяков", 3000, 20), new Worker("Александр","Куншин",1500,20), new Worker("Лихачев","Артем",1000,10)};

            Console.WriteLine("Все работники: ");
            for (int i = 0; i < Workers.Length; i++)
            {
                Console.WriteLine($"Работник{i+1}: ");
                Workers[i].ShowWorkers();
                Console.WriteLine("\n");
            }
            
            Console.Write("Введите номер работника, по которому нужна информация: ");
            int numberWorker = Convert.ToInt32(Console.ReadLine());
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

        public void ShowWorkers()
        {
            Console.Write("Имя работника = " + Name + "\nФамилия = "+ Surname + "\nСтавка в день = "+ Rate + "\nКоличество дней = "+ Days);
        }

        public void Salary()
        {
            int Salary = Rate * Days;
            Console.WriteLine($"Зарплата данного работника составляет: {Salary}");
        }
    }
}
