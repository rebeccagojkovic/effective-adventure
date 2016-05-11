using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift1WindowsFormsApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openFilebutton_Click(object sender, EventArgs e)
        {
            localhost.WebService obj = new localhost.WebService();
            String filename = Convert.ToString(fileNametextBox.Text);
            richTextBox.Text = obj.txtFile(filename);
        }
    }
}
