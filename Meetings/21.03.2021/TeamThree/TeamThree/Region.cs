using System;

namespace TeamThree
{
    public class Region
    {
        private int _id;
        private int _countryId;
        private string _name;
        private string _createdAt;
        
        public Region(int id, int country_id, string name, string crt_date)
        {
            _id = id;
            _countryId = country_id;
            _name = name;
            _createdAt = crt_date;
        }

        public void PrintStates()
        {
            Console.WriteLine($"Id:{_id}, Region_id:{_countryId}, Name:{_name}, Created At:{_createdAt}");
        }
    }
}