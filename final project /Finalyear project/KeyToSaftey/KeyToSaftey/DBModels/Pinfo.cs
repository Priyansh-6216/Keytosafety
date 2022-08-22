using System;
using System.Collections.Generic;

#nullable disable

namespace KeyToSaftey.DBModels
{
    public partial class Pinfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Rating { get; set; }
        public string Price { get; set; }
        public string Img { get; set; }
        public string Link { get; set; }
    }
}
