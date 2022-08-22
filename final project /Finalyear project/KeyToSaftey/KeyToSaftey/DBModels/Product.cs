using System;
using System.Collections.Generic;

#nullable disable

namespace KeyToSaftey.DBModels
{
    public partial class Product
    {
        public int Pid { get; set; }
        public string Pname { get; set; }
        public string Pdes { get; set; }
        public string Catagory { get; set; }
        public byte[] Pimg { get; set; }
        public int? Pprice { get; set; }
        public int? Qnt { get; set; }
    }
}
