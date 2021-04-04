using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace InsertUserToArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет! \n" +
                              "Выбери вариант действия: \n" +
                              "1. Авторизация \n" +
                              "2. Регистрация \n" +
                              "3. Выход. \n");
            
            int coiceUser = Int32.Parse(Console.ReadLine());

            switch (coiceUser)
            {
                case 1:
                    Console.Write("Введите логин: ");
                    string inputLoginUser = Console.ReadLine();
                    Console.Write("Введите пароль: ");
                    string inputPasswordUser = Console.ReadLine();

                    User.SearchToUsers(inputLoginUser, inputPasswordUser);
                    
                    return;
                    break;
                
                case 2:
                    User.RegistrationUser();
                    break;
                
                case 3:
                    Console.WriteLine("Пока!");
                    return;
                    break;
                
                default:
                    Console.WriteLine("Нет такого варианта!");
                    return;
                    break;
            }
        }
    }
    
    class User
    {
        private string _id;
        private string _name;
        private string _login;
        private string _password;
        private string _city;
        private static List<User> _ArrayUsers = new List<User>();

        public string Id => _id;

        public string Name => _name;

        public string Login => _login;

        public string Password => _password;

        public string City => _city;

        public static List<User> ArrayUsers
        {
            get => _ArrayUsers;
            set => _ArrayUsers = value;
        }

        public User(string id, string name, string login, string password, string city)
        {
            _id = id;
            _name = name;
            _login = login;
            _password = password;
            _city = city;
        }
        
        public static void RegistrationUser()
        {
            Guid iId = new Guid();
            
            string idUser = iId.ToString();
            Console.Write("Введите логин: ");
            string newLoginUser = Console.ReadLine();
            Console.Write("Введите пароль: ");
            string newPasswordUser = Console.ReadLine();
            Console.Write("Введите Имя: ");
            string newUserName = Console.ReadLine();
            Console.Write("Введите город: ");
            string newUserCity = Console.ReadLine();
            
            User newUser = new User(idUser, newUserName, newLoginUser, newPasswordUser, newUserCity);
            
            ArrayUsers.Add(newUser);

            foreach (User user in ArrayUsers)
            {
                if (user.Login == newLoginUser && user.Password == newPasswordUser)
                {
                    Console.WriteLine($"\n Успешно. \n" +
                                      $"Ваши личные данные:  \n" +
                                      $"id = {user.Id} \n" +
                                      $"Имя - {user.Name}.  \n" +
                                      $"Логин - {user.Login}. " +
                                      $"Пароль - {user.Password}. \n" +
                                      $"Город - {user.City}.");
                    
                    return;
                }
            }
        }
        
        public static void SearchToUsers(string login, string password)
        {
            User fisrtUser = new User("0","Тимофей", "timofey", "timofey123", "Москва");
            User secondUser = new User("1","Михаил", "mikhail", "mikhail123", "Москва");

            ArrayUsers.Add(fisrtUser);
            ArrayUsers.Add(secondUser);
            
            foreach (User arrayUser in ArrayUsers)
            {
                if (arrayUser.Login == login && arrayUser.Password == password)
                {
                    Console.WriteLine($"\n Успешно. \n "+
                                      $"Ваши личные данные:  \n" +
                                      $"id = {arrayUser.Id} \n" +
                                      $"Имя - {arrayUser.Name}.  \n" +
                                      $"Логин - {arrayUser.Login}. " +
                                      $"Пароль - {arrayUser.Password}. \n" +
                                      $"Город - {arrayUser.City}.");
                    
                    return;
                }
                else 
                {
                    Console.Write("Логин и пароль не совпадают. Не желаете пройти регестрацию? \n" +
                                  "1. Да \n" +
                                  "2. Нет \n");
                    
                    int coiceUser = Int32.Parse(Console.ReadLine());

                    switch (coiceUser)
                    {
                        case 1:
                            RegistrationUser();
                            
                            return;
                            break;
                        
                        case 2:
                            Console.WriteLine("Пока!");
                            
                            return;
                            break;
                        
                        default:
                            Console.WriteLine("Нет такого варианта!");
                            
                            return;
                            break;
                    }
                }
            }
        }
    }
}