using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Uppgift1
{
    public class Controller
    {
        DAL dal = new DAL();
        public string txtFile(string filename)
        {
            return dal.GetTxtFile(filename);

        }
    }
   
    


}
