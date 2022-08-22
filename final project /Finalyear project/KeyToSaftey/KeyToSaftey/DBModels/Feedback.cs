using System;
using System.Collections.Generic;

#nullable disable

namespace KeyToSaftey.DBModels
{
    public partial class Feedback
    {
        public int Id { get; set; }
        public string Mobile { get; set; }
        public string Text { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
    }
}
