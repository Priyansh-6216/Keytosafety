using System;
using System.Collections.Generic;

#nullable disable

namespace KeyToSaftey.DBModels
{
    public partial class AdminSignup
    {
        public int Id { get; set; }
        public string AfullName { get; set; }
        public string Amobile { get; set; }
        public string Aemail { get; set; }
        public string Apassword { get; set; }
    }
}
