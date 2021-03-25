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

        private bool _isRunning = true;

        public void Run()
        {
            ParseData();

            while (_isRunning)
            {
                switch (Console.ReadLine())
                {
                    case "Выход":
                        Console. WriteLine();
                        break;
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