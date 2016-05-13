using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NavWS.Models
{
    public class EmployeeAbsence
    {
        public byte[] timestamp { get; set; }
        public int Entry_No_ { get; set; }
        public string Employee_No_ { get; set; }
        public System.DateTime From_Date { get; set; }
        public System.DateTime To_Date { get; set; }
        public string Cause_of_Absence_Code { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public string Unit_of_Measure_Code { get; set; }
        public decimal Quantity__Base_ { get; set; }
        public decimal Qty__per_Unit_of_Measure { get; set; }
    }
}