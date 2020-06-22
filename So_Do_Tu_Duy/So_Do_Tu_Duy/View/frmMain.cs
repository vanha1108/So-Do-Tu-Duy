using So_Do_Tu_Duy.Controller;
using So_Do_Tu_Duy.View;
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
    public partial class frmMain : Form
    {
        public static int idPro = 0;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn thoát chương trình ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            idPro++;
            frmMain fMain = new frmMain();
            fMain.Close();
            frmMap formMap = new frmMap();
            formMap.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnCreate.Enabled = true;
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            frmListProject fListPr = new frmListProject();
            fListPr.Show();
            BindingSource source = new BindingSource();
            source.DataSource = ProjectController.getListProject();
            fListPr.dtgvListProject.DataSource = source;
 
            fListPr.dtgvListProject.Columns["Shapes"].Visible = false;
        }
    }
}
