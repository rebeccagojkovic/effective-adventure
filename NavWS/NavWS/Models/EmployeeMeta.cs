using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NavWS.Models
{
    public class EmployeeMeta
    {
        public string Table_Name { get; set; }
        public string Column_Name { get; set; }
        public int Object_ID { get; set; }
        public string Constraint_Name { get; set; }

    }
}