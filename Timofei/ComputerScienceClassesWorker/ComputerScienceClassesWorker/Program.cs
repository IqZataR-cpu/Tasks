using System;

namespace ComputerScienceClassesWorker
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker("Тимофей", "Черных", 2400, 30);
            
            worker.Print();
            worker.GetSalary();
        }
    }

    public class Worker
    {
        private string _name;
        private string _surname;
        private int _rate;
        private int _days;

        public string Name => _name;

        public string Surname => _surname;
        
        public int Rate => _rate;
        
        public int Days => _days;
        
        public Worker(string name, string surname, int rate, int days)
        {
            _name = name;
            _surname = surname;
            _rate = rate;
            _days = days;
        }

        public void Print()
        {
            Console.WriteLine($"Имя: {_name}");
            Console.WriteLine($"Фамилия: {_surname}");
            Console.WriteLine($"Ставка сут.: {_rate}");
            Console.WriteLine($"Кол-во отработанных дней: {_days}");
        }

        public void GetSalary()
        {
            Console.WriteLine($"Зарплата сотрудника: {_name} за {_days} работы, составляет {_rate * _days}.");
        }
    }
}