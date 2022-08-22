using System;
using System.Collections.Generic;

#nullable disable

namespace KeyToSaftey.DBModels
{
    public partial class BillingAdd
    {
        public int Id { get; set; }
        public int Orderid { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Addressline01 { get; set; }
        public string Addressline02 { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public decimal? Pincode { get; set; }
        public string Country { get; set; }
        public decimal? Mobile { get; set; }
        public decimal? UserMobile { get; set; }
    }
}
