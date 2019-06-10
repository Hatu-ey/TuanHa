using System;
using System.Collections.Generic;
using System.Text;

namespace TuanHa.Models
{
    public class City
    {
        public int id { get; set; }
        public string name { get; set; }
        public Commune commune { get; set; }
    }
}
