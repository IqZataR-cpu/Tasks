using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ComputerScienceProgramPresonalDataStorage
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DataStorage data = new DataStorage();
           
            data.FormGreeting(); 
        }
    }

    public enum Search
    {
        all,
        search
    }
    
    public class DataBase
    {
        private static readonly string _path = @"C:\Users\User\Desktop\db";
        private static readonly string _name = @"\data.txt";
        private DirectoryInfo _dbInfo = new DirectoryInfo(_path);

        public void ExistsDataBase()
        {
            if (!_dbInfo.Exists)
            {
                _dbInfo.Create();
            }
        }

        public void SelectFromDB(Search search)
        {
            string temp = "";
            Char Sep = ',';

            using (FileStream file = File.OpenRead(_path + _name))
            {
                byte[] array = new byte[file.Length];

                char[] chrArray = new char[file.Length];

                List<string> strArray = new List<string>();

                file.Read(array, 0, array.Length);

                chrArray = System.Text.Encoding.Default.GetChars(array);

                foreach (var p in chrArray)
                {
                    if (p != Sep)
                    {
                        temp += p;
                    }
                    else
                    {
                        strArray.Add(temp);

                        temp = "";
                    }
                }

                if (search == Search.all)
                {
                    ViewAll(strArray);
                }
                else
                {
                    ViewSearch(strArray);
                }
            }
        }

        public void ViewAll(List<string> strArray)
        {
            foreach (var str in strArray)
            {
                Console.Write(str);
            }
        }
        
        public void ViewSearch(List<string> strArray)
        {
            Console.Write("Введите наименование: ");
            string tittle = Console.ReadLine();

            for (int i = 0; i < strArray.Count; i += 3)
            {
                if (strArray[i] == "\n" + tittle)
                {
                    Console.Write(strArray[i]);
                    Console.Write(strArray[i + 1]);
                    Console.WriteLine(strArray[i + 2]);

                    return;
                }
            }
        }

        public void InsertFromDB()
        {
            Console.Write("Введите наименование: ");
            string tittle = Console.ReadLine(); // название сохраняемого значения
            Console.Write("\nВведите пароль: ");
            string password = Console.ReadLine(); // пароль
            Console.Write("\nВведите наименование: ");
            string description = Console.ReadLine(); // описание

            using (FileStream file = new FileStream(_path + _name, FileMode.Append))
            {
                byte[] tittleArray = System.Text.Encoding.Default.GetBytes("\n" + tittle + ",");
                byte[] passwordArray = System.Text.Encoding.Default.GetBytes("\n" + password + ",");
                byte[] descriptionArray = System.Text.Encoding.Default.GetBytes("\n" + description + ",");
               
                file.Write(tittleArray, 0, tittleArray.Length);
                file.Write(passwordArray, 0, passwordArray.Length);
                file.Write(descriptionArray, 0, descriptionArray.Length);
            }
        }
    }
    
    public class DataStorage
    {
        public void FormGreeting()
        {
            DataBase db = new DataBase();
            
            db.ExistsDataBase(); // Создаем папку, где должен располагаться файл
            
            while (true)
            {
                ShowOptions();
                
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        db.SelectFromDB(Search.search);
                        break;
                    case 2:
                        db.InsertFromDB();
                        break;
                    case 3:
                        db.SelectFromDB(Search.all);
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
            
            Console.WriteLine("Нет такого варианта.\n" +
                              "Попробуй ещё раз.");
        }
    }
}