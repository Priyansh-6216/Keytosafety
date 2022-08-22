using System;
using System.Collections.Generic;

#nullable disable

namespace KeyToSaftey.DBModels
{
    public partial class Orderdetail
    {
        public int Id { get; set; }
        public int? Orderid { get; set; }
        public string Pid { get; set; }
        public string Pname { get; set; }
        public string Mobile { get; set; }
        public string Quantity { get; set; }
        public string Price { get; set; }
    }
}
