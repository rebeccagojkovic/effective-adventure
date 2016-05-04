using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavWindowApp.Model
{
    class Employee
    {
        
        public Employee(string No_)
        {
            this.No_ = No_;
        }

       
        public string No_
        { 
            get
            {
                return No_;
            }

            set
            {
                No_ = value;
            }
        }

    }
    }



