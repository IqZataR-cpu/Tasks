using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            int enterData = Int32.Parse(Console.ReadLine());
            int key = 115000;
            int encrypted = 0;
            int decrypted = 0;
            
            encrypted = Function.Xor_cipher(enterData, key,encrypted,decrypted);
            decrypted = (Function.XOR_uncipher(enterData, key, encrypted,decrypted));

            Console.WriteLine($"Зашифрованное сообщение - {encrypted}");
            Console.WriteLine($"Расшифрованное сообщение - {decrypted}");
        }
    }
    
    public class Function
    {
        /// <summary>
        /// Шифрует введенное значение с помощью ключа шифрования (enterData: "введенные данные",key: "ключ").
        /// </summary>
        /// <param name="data"></param>
        /// <param name="key"></param>
        /// <param name="encrypted"></param>
        /// <param name="decrypted"></param>
        /// <returns></returns>
        public static int Xor_cipher(int data, int key, int encrypted, int decrypted)
        {
            return encrypted = data ^ key;
        }
        
        /// <summary>
        /// Восстанавливает исходную строку (enterData: "зашифрованные данные", key: "ключ").
        /// </summary>
        /// <param name="data"></param>
        /// <param name="key"></param>
        /// <param name="encrypted"></param>
        /// <param name="decrypted"></param>
        /// <returns></returns>
        public static int XOR_uncipher(int data, int key, int encrypted, int decrypted)
        {
             return decrypted = encrypted ^ key;
        }
    }
}