using So_Do_Tu_Duy.Controller;
using So_Do_Tu_Duy.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace So_Do_Tu_Duy.View
{
    public partial class frmListProject : Form
    {
        public frmListProject()
        {
            InitializeComponent();
            this.cIDPro.DataPropertyName = nameof(ProjectShape.IDPro);
            this.cNote.DataPropertyName = nameof(ProjectShape.Note);
        }

        private void btnOpenProject_Click(object sender, EventArgs e)
        {
            
        }
    }
}
