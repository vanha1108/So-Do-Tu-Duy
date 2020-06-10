using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace So_Do_Tu_Duy
{
    public partial class frmMap : Form
    {
        // Phần Graphic
        int typeObj = -1;
        bool isDraw = true;
    
        Bitmap bm;
        Graphics g1, g2;
        Pen myPen;
        SolidBrush solidBrush;

        Root root;


        public frmMap()
        {
            InitializeComponent();
            g2 = ptbDraw.CreateGraphics();
            bm = new Bitmap(ptbDraw.Width, ptbDraw.Height);
            g1 = Graphics.FromImage(bm);

            solidBrush = new SolidBrush(Color.Black);
            myPen = new Pen(Color.Black);
            myPen.DashStyle = DashStyle.Solid;
            myPen.Width = 2;

            root = new Root("Root",new Point(ptbDraw.Width/2 - DefineSize.Width_Main/2, ptbDraw.Height/2 - DefineSize.Height_Main/2),DefineSize.Width_Main,DefineSize.Height_Main);
            
            g1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

        }  

        private void frmMap_Load(object sender, EventArgs e)
        {
        }

        private void btnTopic_Click(object sender, EventArgs e)
        {
            isDraw = true;
            typeObj = 1;
            btnTopic.BackColor = Color.GreenYellow;
        }

        public bool Find_Point(DrawObject obj, Point p)
        {          
            if (obj.Name == "Rectangle")      // Điểm click thuộc hình chữ nhật
            {
                if (obj.Point.X < p.X &&
                    obj.Point.X + DefineSize.Width > p.X &&
                    obj.Point.Y < p.Y &&
                    obj.Point.Y + DefineSize.Height > p.Y ||
                    obj.Point.X > p.X &&
                    obj.Point.X + DefineSize.Width < p.X &&
                    obj.Point.Y > p.Y &&
                    obj.Point.Y + DefineSize.Height < p.Y)
                    return true;   
            }
            return false;
        }

        private void ptbDraw_MouseDoubleClick(object sender, MouseEventArgs e)
        {
             foreach( var shape in root.lstObj)
             {
                if ( Find_Point(shape,e.Location) == true )
                {
                    RichTextBox rt = new RichTextBox();
                    rt.Visible = true;
                    rt.Location = new Point(shape.Point.X + 1,shape.Point.Y + 1);
                    rt.Size = new Size(shape.Witdh - 2,shape.Height -2);
                    rt.Text = "Ghi nội dung của Topic";
                    ptbDraw.Controls.Add(rt);
                }  
             }    
        }

        private void btnSubTopic_Click(object sender, EventArgs e)
        {
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnRelationship_Click(object sender, EventArgs e)
        {
            
        }

        private void outlinerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOutliner frm = new frmOutliner();
            frm.Show();
        }

        private void mindMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            
        }

        public void DrawObj( Root root)
        {
            root.Draw(g2, myPen);
            RichTextBox rt = new RichTextBox();
            rt.Visible = true;
            rt.Location = new Point(ptbDraw.Width / 2 - DefineSize.Width_Main / 2 + 1, ptbDraw.Height / 2 - DefineSize.Height_Main / 2 + 1);
            rt.Size = new Size(DefineSize.Width_Main-2, DefineSize.Height_Main-2);
            rt.Text = "Ghi nội dung của Main Topic";
            ptbDraw.Controls.Add(rt);
            foreach (var shape in root.lstObj)
            {
                if(shape.Name=="Root")
                {
                    DrawObj((Root)shape);
                   
                }
                else
                {
                    shape.Draw(g2, myPen);
                }
            }
        }

        public void ResetColor()
        {
            btnTopic.BackColor = Color.WhiteSmoke;
            btnSubTopic.BackColor = Color.WhiteSmoke;
            btnRelationship.BackColor = Color.WhiteSmoke;
        }

        private void ptbDraw_MouseClick(object sender, MouseEventArgs e)
        {
            if (isDraw == true)
            {
                if (typeObj == 1)
                {
                    Rec rec = new Rec("Rectangle",e.Location, DefineSize.Width, DefineSize.Height);
                    root.lstObj.Add(rec);
                    isDraw = false;
                } else if ( typeObj == 2 )
                {
                    
                }

                DrawObj(root);
                g2.DrawImage(bm, 0, 0);
                isDraw = false;
                ResetColor();
            }
        }

        private void btnCloseMap_Click(object sender, EventArgs e)
        {
            frmMain formMain = new frmMain();
            formMain.Close();
            this.Close();
            //Application.Exit();

        }

        private void frmMap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn đóng cửa sổ hiện tại ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

    }
}
