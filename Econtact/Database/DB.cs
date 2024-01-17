using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Econtact.Database
{
    public class DB
    {
        public static string myConnection = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
    }
}
