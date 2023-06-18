using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.ComponentModel;

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
//{
//    public class City
//    {
//        public int Idcity { get; set; }
//        public string CityName { get; set; }

//        public City() { }

//        public City(int idcity, string cityname)
//        {

//            this.Idcity = idcity;
//            this.CityName = cityname;

//        }
//    }

//    public class PMarker
//    {
//        public int MarkerId { get; set; }
//        public int Number { get; set; }
//        public int Idcity { get; set; }
//        public int DataTime { get; set; }
//        public double Longitude { get; set; }
//        public double Latitude { get; set; }

//        public virtual City City { get; set; }
//        public virtual Sample Sample { get; set; }

//        public PMarker() { }
  
//        public PMarker(int markerid, int number, int idcity, int datetime, double longitude, double latitude)
//        {

//            this.MarkerId = markerid;
//            this.Number = number;
//            this.Idcity = idcity;
//            this.DataTime = datetime;
//            this.Longitude = longitude;
//            this.Latitude = latitude;

//        }
//    }

//    public class Sample
//    {
//        public int Id { get; set; }
//        public int MarkerId { get; set; }
//        public double SampleValue { get; set; }

//        public virtual PMarker Marker { get; set; }

//        public Sample() { }

//        public Sample(int id, int markerid, double samplevalue)
//        {

//            this.Id = id;
//            this.MarkerId = markerid;
//            this.SampleValue = samplevalue;

//        }
//    }  
//}
