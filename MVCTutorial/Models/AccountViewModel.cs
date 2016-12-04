using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTutorial.Models
{
    public class AccountViewModel
    {
        public DataModel.Account Account { get; set; }

        public string Foutmelding { get; set; }
        public string Invulvelden { get; set; }

        public List<string> MogelijkeRechten { get; set; }
    }
}