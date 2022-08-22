using System;
using System.Collections.Generic;

#nullable disable

namespace KeyToSaftey.DBModels
{
    public partial class Ordermaster
    {
        public decimal Orderid { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public decimal? Mobile { get; set; }
        public string Country { get; set; }
        public string Addressline01 { get; set; }
        public string Adressline02 { get; set; }
        public string City { get; set; }
        public decimal Pincode { get; set; }
        public string State { get; set; }
        public string Email { get; set; }
        public string UserMobile { get; set; }
        public string Status { get; set; }
    }
}
