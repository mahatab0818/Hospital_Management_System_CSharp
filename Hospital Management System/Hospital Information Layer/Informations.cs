using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Information_Layer
{
    public class Informations
    {
        public int eid { get; set; }
        public string name { get; set; }
        public string gender { get; set; }
        public string dob { get; set; }
        public string age { get; set; }
        public string address { get; set; }
        public string phoneNo { get; set; }
        public string designation { get; set; }
        public string userType { get; set; }
        public string password { get; set; }

        public int pid { get; set; }

        public int did { get; set; }
        public string dstatus { get; set; }
        public string description { get; set; }
        public string operation { get; set; }
        public string cabin { get; set; }
        public int days { get; set; }
        public string medicin { get; set; }
        public string bstatus { get; set; }

        public float bill { get; set; }
    }
}
