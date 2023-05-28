using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace HydrargyrumBaikal
{
    class Point
    {
        private int id { get; set; }

        private string CityName;

        private double longitude, latitude, sample;

        public Point() { }


        public Point(string CityName, double longitude, double latitude, double sample)
        {
            this.CityName = CityName;
            this.longitude = longitude;
            this.latitude = latitude;
            this.sample = sample;
        }
    }
}
