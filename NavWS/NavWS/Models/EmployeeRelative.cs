using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NavWS.Models
{
    public class EmployeeRelative
    {
        public byte[] timestamp { get; set; }
        public string Employee_No_ { get; set; }
        public int Line_No_ { get; set; }
        public string Relative_Code { get; set; }
        public string First_Name { get; set; }
        public string Middle_Name { get; set; }
        public string Last_Name { get; set; }
        public System.DateTime Birth_Date { get; set; }
        public string Phone_No_ { get; set; }
        public string Relative_s_Employee_No_ { get; set; }
    }
}