using System;

namespace TeamThree
{
    public class Country
    {
        private int _id;
        private string _name;
        private string _createdAt;
        
        public Country(int id, string name, string crt_date)
        {
            _id = id;
            _name = name;
            _createdAt = crt_date;
        }

        public void PrintStates()
        {
            Console.WriteLine($"Id:{_id}, Name:{_name}, Created At:{_createdAt}");
        }
    }
}