using System;
using System.Collections.Generic;
using System.Text;

namespace TuanHa.Models
{
    public class DataModel
    {

        public int id { get; set; }
        public string stationName { get; set; }
        public string gegrLat { get; set; }
        public string gegrLon { get; set; }
        public Models.City city { get; set; }
        public string addressStreet { get; set; }

    }
}
