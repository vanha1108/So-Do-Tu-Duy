using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace So_Do_Tu_Duy
{
    public partial class frmMain : Form
    {
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
            //this.Hide();
            frmMap formMap = new frmMap();
            formMap.ShowDialog();
        }
    }
}
