using System;

namespace TeamThree.Models
{
    public class Region : Model
    {
        private int _countryId;
        private string _createdAt;
        
        public Region(int id, int country_id, string name, string crt_date) : base(id, name)
        {
            _countryId = country_id;
            _createdAt = crt_date;
        }
    }
}