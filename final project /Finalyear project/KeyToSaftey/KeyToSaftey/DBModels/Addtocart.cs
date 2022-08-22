using System;
using System.Collections.Generic;

#nullable disable

namespace KeyToSaftey.DBModels
{
    public partial class Addtocart
    {
        public int Id { get; set; }
        public int? Pid { get; set; }
        public string Pname { get; set; }
        public string Mobile { get; set; }
        public string Quantity { get; set; }
        public decimal? Price { get; set; }
        public byte[] Pimg { get; set; }
        public int? Pprice { get; set; }
    }
}
