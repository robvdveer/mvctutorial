using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTutorial.Models.DataModel
{
    public class Account
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public DateTime Expires { get; set; }
        public DateTime Created { get; set; }
        public bool IsEnabled { get; set; }
    }
}