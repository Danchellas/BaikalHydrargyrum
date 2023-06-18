using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.ComponentModel;
using Microsoft.EntityFrameworkCore;

namespace HydrargyrumBaikal
{
    public class Marker
    {
        public int ID { get; set; }
        public string CityName { get; set; }
        public Int64 Number { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public double Sample { get; set; }

        public Marker() { }

        public Marker(int id, string cityName, double longitude, double latitude, double sample, Int64 number)
        {

            this.ID = id;
            this.Number = number;
            this.CityName = cityName;
            this.Longitude = longitude;
            this.Latitude = latitude;
            this.Sample = sample;

        }
    }

}
