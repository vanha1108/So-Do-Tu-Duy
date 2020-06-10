using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace So_Do_Tu_Duy
{
    public partial class frmOutliner : Form
    {
        public static string note = "";
        public frmOutliner()
        {
            InitializeComponent();
            rtOutliner.Text = note;   
        }

        private void rtOutliner_TextChanged(object sender, EventArgs e)
        {
            note = rtOutliner.Text;
        }
    }
}
