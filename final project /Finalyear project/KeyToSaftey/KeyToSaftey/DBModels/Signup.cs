using System;
using System.Collections.Generic;

#nullable disable

namespace KeyToSaftey.DBModels
{
    public partial class Signup
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string Password { get; set; }
    }
}
