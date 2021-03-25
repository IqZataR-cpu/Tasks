using System;

namespace TeamThree
{
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