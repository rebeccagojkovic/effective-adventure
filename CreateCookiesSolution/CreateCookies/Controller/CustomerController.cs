using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CreateCookies.Controller
{
    class CustomerController
    {
        private Form1 gui;
        private CreateCookiesDataSet db;


        public CustomerController(Form1 gui, CreateCookiesDataSet db)
        {

            this.db = db;
            this.gui = gui;
    
            

        }
       
    }
}
