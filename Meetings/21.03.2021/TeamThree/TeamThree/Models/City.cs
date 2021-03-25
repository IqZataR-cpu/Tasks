using System;

namespace TeamThree.Models
{
    public class City : Model
    {
        private int _regionId;
        private string _createdAt;
        
        public City(int id, int region_id, string name, string crt_date) : base(id, name)
        {
            _regionId = region_id;
            _createdAt = crt_date;
        }
    }
}