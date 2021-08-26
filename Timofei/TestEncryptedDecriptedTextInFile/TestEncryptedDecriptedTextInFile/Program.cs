 using System;
 using System.IO;
 using System.Security.Cryptography;

 namespace TestEncryptedDecriptedTextInFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Encrypted encrypted = new Encrypted();
            Decrypted decrypted = new Decrypted();
            
          

            while (true)
            {
                ShowOptions();
                int choice = int.Parse(Console.ReadLine());
                
                switch (choice)
                {
                    case 1:
                   
                        break;
                    case 2:
                        Console.Write("Введите наименование: ");
                        string tittle = Console.ReadLine(); 
                        Console.Write("\nВведите пароль: ");
                        string password = Console.ReadLine();
                        Console.Write("\nВведите наименование: ");
                        string description = Console.ReadLine();
                    
                        encrypted.EncryptedText(tittle, password, description);
                        break;
                    case 3:
                        decrypted.DecryptedText();
                        break; 
                    case 4:
                        return;
                        break;
                    default:
                        ShowOptionsError();
                        break;
                }
            }
        }
        
        private static void ShowOptions()
        {
            Console.WriteLine("1. Поиск.");
            Console.WriteLine("2. Добавление.");
            Console.WriteLine("3. Просмотр всех.");
            Console.WriteLine("4. Выход.");
        }
        
        private static void ShowOptionsError()
        {
            Console.Clear();
            
            Console.WriteLine("Нет такого варианта.\n Попробуй ещё раз.");
        }
    }
}

 public abstract class Path
 {
     protected static string _path = @"C:\Users\User\Desktop\db\";
     protected static string _name = @"data.txt";
     
     protected static string _pathSettings = @"C:\Users\User\Desktop\db\";
     protected static string _nameSettings = @"settings.txt";
 }

 
 public class Encrypted : Path
 {
     public void EncryptedText(string tittle, string password, string description)
     {
         try
         {
             using (FileStream fileStream = new FileStream(_path + _name, FileMode.Append))
             {
                 using (Aes aes = Aes.Create())
                 {
                     byte[] key =
                     {
                         0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08,
                         0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16
                     };
                     aes.Key = key;

                     byte[] iv = aes.IV;
                     fileStream.Write(iv, 0, iv.Length);

                     using (CryptoStream cryptoStream = new CryptoStream(fileStream, aes.CreateEncryptor(),CryptoStreamMode.Write))
                     {
                         using (StreamWriter encryptWriter = new StreamWriter(cryptoStream))
                         {
                             encryptWriter.WriteLine($"{tittle}");
                             encryptWriter.WriteLine($"{password}");
                             encryptWriter.WriteLine($"{description}");
                         }
                     }
                 }
             }
         }
         catch (Exception e)
         {
             Console.WriteLine($"Ошибка. {e}");
             throw;
         }
     }
 }
 public class Decrypted : Path
 {
     public void DecryptedText()
     {
         try
         {
             using (FileStream fileStream = new FileStream(_path + _name, FileMode.Open))
             {
                 using (Aes aes = Aes.Create())
                 {
                     byte[] iv = new byte[aes.IV.Length];
                     int numBytesToRead = aes.IV.Length;
                     int numBytesRead = 0;
                     while (numBytesToRead > 0)
                     {
                         int n = fileStream.Read(iv, numBytesRead, numBytesToRead);
                         if (n == 0) break;

                         numBytesRead += n;
                         numBytesToRead -= n;
                     }

                     byte[] key =
                     {
                         0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08,
                         0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16
                     };

                     using (CryptoStream cryptoStream = new CryptoStream(
                         fileStream,
                         aes.CreateDecryptor(key, iv),
                         CryptoStreamMode.Read))
                     {
                         using (StreamReader decryptReader = new StreamReader(cryptoStream))
                         {
                             string decryptedMessage = decryptReader.ReadToEnd();
                             Console.WriteLine($"{decryptedMessage}");
                         }
                     }
                 }
             }
         }
         catch (Exception ex)
         {
             Console.WriteLine($"The decryption failed. {ex}");
         }
         
         Console.WriteLine("Нажми на кнопку чтобы продолжить");
         Console.ReadLine();
     }
 }