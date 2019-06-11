using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DövizAlSatDemo
{
    class User
    {
        public int Id { get; set; }
        public string NickName { get; set; }
        public string Sifre { get; set; }
        public double TlBakiye { get; set; }
        public double DlBakiye { get; set; }
        public double EuBakiye { get; set; }
        public string Role { get; set; }
        public string Status { get; set; }
    }
}
