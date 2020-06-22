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
        public static int OpenPro = -1;
        public frmListProject()
        {
            InitializeComponent();
            this.cIDPro.DataPropertyName = nameof(ProjectShape.IDPro);
            this.cNote.DataPropertyName = nameof(ProjectShape.Note);
        }

        private void btnOpenProject_Click(object sender, EventArgs e)
        {
            int x = int.Parse(this.dtgvListProject.CurrentRow.Cells[0].Value.ToString());
            OpenPro = x;
            this.Close();
          
            frmMap fMap = new frmMap();
            fMap.Show();
            List<Shape> openShape = new List<Shape>();
            Root openRoot = new Root(0, "Root", new Point( fMap.ptbDraw.Width/ 2 - DefineSize.Width_Main / 2, fMap.ptbDraw.Height / 2 - DefineSize.Height_Main / 2), DefineSize.Width_Main, DefineSize.Height_Main);
            
            openShape = ShapeController.getListShape();
            //MessageBox.Show(openShape.Count() + "");
            foreach ( var s in openShape )
            {
                if ( s.NameShape == "Root" )
                {
                    //MessageBox.Show("There");
                    Root root = new Root(s.ID, "Root", new Point(Convert.ToInt32(s.LocationX),Convert.ToInt32(s.LocationY)), Convert.ToInt32(s.Witdh), Convert.ToInt32(s.Height));
                    root.Draw(fMap.g2, fMap.myPen);
                    Infor infor = TextController.getInfor(s.ID);
                    if ( infor != null )
                    {
                        RichTextBox rt = new RichTextBox();
                        rt.Visible = true;
                        rt.Location = new Point( Convert.ToInt32(infor.LocationX), Convert.ToInt32(infor.LocationY));
                        rt.Size = new Size(Convert.ToInt32(infor.Witdh), Convert.ToInt32(infor.Height));
                        rt.Text = infor.Description;
                        rt.Tag = infor.ID;
                        fMap.ptbDraw.Controls.Add(rt);
                        fMap.lstRt.Add(rt);
                    }    
                }
                
            }    
        }
    }
}
