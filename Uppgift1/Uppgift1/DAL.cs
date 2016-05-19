using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;

namespace Uppgift1
{
    public class DAL
    {
        public string GetTxtFile(string filename)
        {
            StreamReader sr = File.OpenText("C:\\Users\\Azra Balic\\" + filename);
            String line = sr.ReadToEnd();
            return line;
        }
    }
   
}