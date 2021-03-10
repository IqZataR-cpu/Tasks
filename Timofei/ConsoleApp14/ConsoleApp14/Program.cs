using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            // В целом все неплохо, думаю ты сможешь и хард выполнить
            // Но будь внимательнее с текстом задания и видом программы
            // По себе знаю, Михаил может не пощадить на соревах
            // Data не самое лучшее для название переменной, так как
            // Не ясно, какие данные она конкретно несет в себе
            // Переменную key можно сделать константой, если она
            // Не меняется в программе
            int data = Int32.Parse(Console.ReadLine());
            int key = 115000;
            int encrypted = 0;
            int decrypted = 0;
            
            // Не забываем про пробелы, для удобного восприятия
            // При чтении кода программы
            encrypted = Function.XorEncrypted(data, key,encrypted,decrypted);
            decrypted = (Function.XorDecrypted(data, key, encrypted,decrypted));

            Console.WriteLine($"Зашифрованное сообщение - {encrypted}");
            Console.WriteLine($"Расшифрованное сообщение - {decrypted}");
        }
    }
    
    // Название функции также, лучше всего переименовать
    // Во-первых, потому что не ясно отражена суть функции
    // Во-вторых, в самом задании дано название функции
    // ТЗ - это немаловажная часть создание продукта
    
    public class Function
    {
        public static int XorEncrypted(int data, int key, int encrypted, int decrypted)
        {
            // Это можно записать так return encrypted = data ^ key
            encrypted = data ^ key;
            
            return encrypted;
        }
        
        public static int XorDecrypted(int data, int key, int encrypted, int decrypted)
        {
            // Тоже самое, что и в первом случае
            decrypted = encrypted ^ key;
            
            return decrypted;
        }
    }
}