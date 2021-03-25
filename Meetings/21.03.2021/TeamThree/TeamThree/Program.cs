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
            var contries = JsonConvert.DeserializeObject<Country[]>(File.ReadAllText("../../../countries.json"));
            var regions = JsonConvert.DeserializeObject<Region[]>(File.ReadAllText("../../../regions.json"));

            for (int i = 0; i < 1000; i++)
            {
                contries[i].PrintStates();
            }
        }
    }
}