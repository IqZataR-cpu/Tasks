using System;

namespace TeamThree.Models
{
    public class Country : Model
    {
        private string _createdAt;
        
        public Country(int id, string name, string crt_date) : base(id, name)
        {
            _createdAt = crt_date;
        }
    }
}