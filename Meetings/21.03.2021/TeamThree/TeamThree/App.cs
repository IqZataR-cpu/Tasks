using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using TeamThree.Models;

namespace TeamThree
{
    public class App
    {
        private List<Country> _countries = new List<Country>();
        private List<Region> _regions = new List<Region>();
        private List<City> _cities = new List<City>();
        private List<User> _users = new List<User>();

        private User _currentUser;

        private enum UserChoices
        {
            Exit = 1,
            Login = 2,
            Registration = 3,
            InfoAboutCountry = 4,
            InfoAboutRegion = 5,
            InfoAboutCity = 6,
            RandomCountry = 7,
            TenRandomCites = 8,
        }
        
        private bool _isRunning = true;

        public void Run()
        {
            ParseData();

            while (_isRunning)
            {
                if (_currentUser == null)
                {
                    switch ((UserChoices) int.Parse(Console.ReadLine()))
                    {
                        case UserChoices.Login:
                            Console. WriteLine("Введите логин и пароль");
                            break;
                        case UserChoices.Exit:
                            Console. WriteLine("Бывай друже");
                            _isRunning = false;
                            break;
                        case UserChoices.Registration:
                            Console. WriteLine("Регистрация");
                            break;
                    }
                }
                else
                {
                    switch ((UserChoices) int.Parse(Console.ReadLine()))
                    {
                        case UserChoices.InfoAboutCity:
                            Console. WriteLine("Введите название города");
                            break;
                        case UserChoices.InfoAboutRegion:
                            Console. WriteLine("Введите название региона");
                            break;
                        case UserChoices.InfoAboutCountry:
                            Console. WriteLine("Введите название страны");
                            break;
                        case UserChoices.TenRandomCites:
                            Console. WriteLine("Введите название страны информацию о 10 рандомных городах " +
                                               "вы хотите получить");
                            break;
                        case UserChoices.RandomCountry:
                            Console. WriteLine("Сиди лучше дома");
                            break;
                        case UserChoices.Exit:
                            Console. WriteLine("Бывай друже");
                            _isRunning = false;
                            break;
                    }
                }
            }
        }

        private void ParseData()
        {
            ParseCities();
            ParseRegions();
            ParseCountries();
        }

        private void ParseCountries()
        {
            _countries = new List<Country>(
                JsonConvert.DeserializeObject<Country[]>(
                    File.ReadAllText("../../../countries.json")
                ) ?? Array.Empty<Country>()
            );
        }

        private void ParseRegions()
        {
            _regions = new List<Region>(
                JsonConvert.DeserializeObject<Region[]>(
                    File.ReadAllText("../../../regions.json")
                ) ?? Array.Empty<Region>()
            );
        }

        private void ParseCities()
        {
            _cities = new List<City>(
                JsonConvert.DeserializeObject<City[]>(
                    File.ReadAllText("../../../cities.json")
                ) ?? Array.Empty<City>()
            );
        }
    }
}