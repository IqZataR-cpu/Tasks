 using System;
 using System.Collections.Generic;
 using System.IO;
 using System.Linq;
 using System.Security.Cryptography;
 using TestEncryptedDecriptedTextInFile;

 namespace TestEncryptedDecriptedTextInFile
{
   public enum ChoiceSearch
    {
        search,
        all
    }
   
    public class Program
    {
        public static void Main(string[] args)
        {
            Encrypted encrypted = new Encrypted();
            Decrypted decrypted = new Decrypted();
            Key key = new Key();

            key.AddKey();

            while (true)
            {
                ShowOptions();
                int choice = int.Parse(Console.ReadLine());
                
                switch (choice)
                {
                    case 1:
                        decrypted.DecryptedText(ChoiceSearch.search);
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
                        decrypted.DecryptedText(ChoiceSearch.all);
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
 
 public class Key : Path
 {
     
     public void AddKey() 
     {
         try
         {
             if (!File.Exists(_pathSettings + _nameSettings))
             {
                 using (FileStream file = new FileStream(_pathSettings + _nameSettings, FileMode.OpenOrCreate))
                 {
                     Console.WriteLine("Введите ключ (16 cимволов): ");
            
                     string inputKey =  Console.ReadLine();
                     char[] ch = inputKey.ToCharArray();
                         
                     byte[] key = System.Text.Encoding.UTF8.GetBytes(ch);
                
                     file.Write(key, 0, key.Length);
                 }
             }
         }
         catch (Exception e)
         {
             Console.WriteLine($"Ошибка. {e}");
             throw;
         }
     }

     public static byte[] GetKey()
     {
         try
         {
             using (FileStream file = File.OpenRead(_pathSettings + _nameSettings))
             {
                 byte[] array = new byte[file.Length];
              
                 file.Read(array, 0, array.Length);
                 
                 return array;
             }
         }
         catch (Exception e)
         {
             Console.WriteLine($"Ошибка. {e}");
             throw;
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
                     byte[] key = Key.GetKey();
                     aes.Key = key;

                     byte[] iv = aes.IV;
                     
                     fileStream.Write(iv, 0, iv.Length);

                     using (CryptoStream cryptoStream = new CryptoStream(fileStream, aes.CreateEncryptor(),CryptoStreamMode.Write))
                     {
                         using (StreamWriter encryptWriter = new StreamWriter(cryptoStream))
                         {
                             encryptWriter.Write($"{"," + tittle + ","}");
                             encryptWriter.Write($"{"," + password + ","}");
                             encryptWriter.Write($"{"," + description + ","}");
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
     public void DecryptedText(ChoiceSearch choiceSearch)
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

                     byte[] key = Key.GetKey();

                     using (CryptoStream cryptoStream = new CryptoStream(
                         fileStream,
                         aes.CreateDecryptor(key, iv),
                         CryptoStreamMode.Read))
                     {
                         using (StreamReader decryptReader = new StreamReader(cryptoStream))
                         {
                             string decryptedMessage = decryptReader.ReadToEnd();
                             
                             string temp = "";
                             Char[] separator = new char[]
                             {
                                 ',',
                                 '\r',
                                 '\n',
                                 '\0',
                                 '/',
                             };
         
                             char[] chrArray = new char[decryptedMessage.Length];
                             List<string> strArray = new List<string>();
         
                             chrArray = decryptedMessage.ToCharArray();
                          
                             foreach (var p in chrArray)
                             {
                                 if (!separator.Contains(p))
                                 {
                                     temp += p;
                                 }
                                 else 
                                 {
                                     strArray.Add(temp);
         
                                     temp = "";
                                 }
                             }

                             if (choiceSearch == ChoiceSearch.all)
                             {
                                 SearchAll(strArray);
                             }
                             else if (choiceSearch == ChoiceSearch.search)
                             {
                                 SearchByName(strArray);
                             }
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

     private void SearchAll(List<string> strArray)
     {
         foreach (var str in strArray)
         {
             if (str != "")
             {
                 Console.WriteLine($"{str}");
             }
         }
     }
     
     private void SearchByName(List<string> strArray)
     {
         Console.Write("Введите наименование: ");
         string tittle = Console.ReadLine();
         
         for (int i = 1; i < strArray.Count; i += 2)
         {
             if (strArray[i] == tittle)
             {
                 Console.WriteLine(strArray[i]);
                 Console.WriteLine(strArray[i + 2]);
                 Console.WriteLine(strArray[i + 4]);
                 
                 return;
             }
         }
     }
 }