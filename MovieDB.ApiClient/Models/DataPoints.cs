using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieDB.ApiClient.Models
{
    public class DataPoint
    {
        public string Label { get; set; }
        public int Y { get; set; }
        
        public DataPoint(string label, int y)
        {
            Label = label;
            Y = y;
        }

    }
}
