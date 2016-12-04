using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTutorial.DataAccess
{
    public class AccountContext
    {
       public Models.DataModel.Account GetCurrentAcount()
        {
            //insert database shizzle
            return new Models.DataModel.Account() { Username = "Cataclysm" };
        }
    }
}