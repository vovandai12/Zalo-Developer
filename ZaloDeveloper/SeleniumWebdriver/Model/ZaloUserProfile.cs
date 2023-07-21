using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver.Model
{
    public class ZaloUserProfile
    {
        public byte[] avatar { get; set; }
        public string fullName { get; set; }
        public string phone { get; set; }
        public bool gender { get; set; }
        public DateTime birthDay { get; set; }

        public ZaloUserProfile() { }
    }
}
