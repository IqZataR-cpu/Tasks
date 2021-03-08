using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            int data = Int32.Parse(Console.ReadLine());
            int key = 115000;
            int encrypted = 0;
            int decrypted = 0;
            
            encrypted = Function.XorEncrypted(data, key,encrypted,decrypted);
            decrypted = (Function.XorDecrypted(data, key, encrypted,decrypted));

            Console.WriteLine($"Зашифрованное сообщение - {encrypted}");
            Console.WriteLine($"Расшифрованное сообщение - {decrypted}");
        }
    }
    
    public class Function
    {
        public static int XorEncrypted(int data, int key, int encrypted, int decrypted)
        {
            encrypted = data ^ key;
            
            return encrypted;
        }
        
        public static int XorDecrypted(int data, int key, int encrypted, int decrypted)
        {
            decrypted = encrypted ^ key;
            
            return decrypted;
        }
    }
}