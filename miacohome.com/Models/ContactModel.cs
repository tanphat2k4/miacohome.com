using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace miacohome.com.Models
{
    public class ContactModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string message { get; set; }
        public string subject { get; set; }

    }
}