using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TeamThree
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var cities = JsonConvert.DeserializeObject<City[]>(File.ReadAllText("../../../cities.json"));
            var contries = JsonConvert.DeserializeObject<JObject[]>(File.ReadAllText("../../../countries.json"));
            var regions = JsonConvert.DeserializeObject<JObject[]>(File.ReadAllText("../../../regions.json"));

            for (int i = 0; i < 1000; i++)
            {
                cities[i].PrintStates();
            }
        }
    }

    public class City
    {
        private int _id;
        private int _regionId;
        private string _name;
        private string _createdAt;
        
        public City(int id, int region_id, string name, string crt_date)
        {
            _id = id;
            _regionId = region_id;
            _name = name;
            _createdAt = crt_date;
        }

        public void PrintStates()
        {
            Console.WriteLine($"Id:{_id}, Region_id:{_regionId}, Name:{_name}, Created At:{_createdAt}");
        }
    }
}