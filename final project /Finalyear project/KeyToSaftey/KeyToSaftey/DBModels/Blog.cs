using System;
using System.Collections.Generic;

#nullable disable

namespace KeyToSaftey.DBModels
{
    public partial class Blog
    {
        public int Bid { get; set; }
        public DateTime Date { get; set; }
        public string Bname { get; set; }
        public string Bpara { get; set; }
        public string Bdetails { get; set; }
        public byte[] Bimage { get; set; }
        public string Bauthor { get; set; }
        public string Bstatus { get; set; }
    }
}
