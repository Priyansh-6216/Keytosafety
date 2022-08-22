using System;
using System.Collections.Generic;

#nullable disable

namespace KeyToSaftey.DBModels
{
    public partial class Image
    {
        public int Id { get; set; }
        public int? Pid { get; set; }
        public byte[] Image1 { get; set; }
    }
}
