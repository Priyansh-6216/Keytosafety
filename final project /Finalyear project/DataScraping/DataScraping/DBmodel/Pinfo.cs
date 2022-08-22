using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataScraping.DBmodel
{
    public class Pinfo
    {
        public string name { get; set; }
        public string price { get; set; }
        public string rating { get; set; }
        public string img { get; set; }
        public string link { get; set; }

        public static explicit operator List<object>(Pinfo v)
        {
            throw new NotImplementedException();
        }
    }
}
