using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
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
        Color myColor;
        Pen myPen;
        Bitmap bm;
        Graphics g1, g2;
        SolidBrush myBrush;
        DrawObject myObj;

        List<DrawObject> lstObj = new List<DrawObject>();           // danh sách hình

        bool isPress = false;

        public frmMap()
        {
            InitializeComponent();
            g1 = ptbDraw.CreateGraphics();
            bm = new Bitmap(ptbDraw.Width, ptbDraw.Height);
            g2 = Graphics.FromImage(bm);
            myColor = Color.Black;
            myPen = new Pen(myColor);
            myBrush = new SolidBrush(myColor);
            g2.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

        }

        private void btnCloseMap_Click(object sender, EventArgs e)
        {
            frmMain formMain = new frmMain();
            formMain.Close();
            this.Close();
            //Application.Exit();

        }

        public void Draw_Initialize()
        {
            DrawObject r = new Rec();

            r.p1 = new Point(ptbDraw.Width / 2 - 100, ptbDraw.Height / 2 - 100);
            r.myColor = myColor;
            r.mySize = 2;
            r.type = 1;
            r.myPen = myPen;
            r.myBrush = myBrush;

            this.lstObj.Add(r);

            r.p2 = new Point(ptbDraw.Width / 2 + 70, ptbDraw.Height / 2);
            r.init();
            r.Draw(this.g1, this.lstObj[0].myPen, this.lstObj[0].myColor);
            g1.DrawImage(bm, 0, 0);
            
        }

        private void frmMap_Load(object sender, EventArgs e)
        {
            Draw_Initialize();
        }

        private void btnTopic_Click(object sender, EventArgs e)
        {
            
        }

        public bool Find_Point(DrawObject obj, Point p)
        {  
            if (obj.type == 4)          // Điểm click thuộc đường thẳng
            {
                int a = Convert.ToInt32(Math.Sqrt((obj.p1.X - p.X) * (obj.p1.X - p.X) + (obj.p1.Y - p.Y) * (obj.p1.Y - p.Y)));
                int b = Convert.ToInt32(Math.Sqrt((obj.p2.X - p.X) * (obj.p2.X - p.X) + (obj.p2.Y - p.Y) * (obj.p2.Y - p.Y)));
                int c = Convert.ToInt32(Math.Sqrt((obj.p1.X - obj.p2.X) * (obj.p1.X - obj.p2.X) + (obj.p1.Y - obj.p2.Y) * (obj.p1.Y - obj.p2.Y)));

                if (a + b == c) 
                    return true;
            }
            if (obj.type == 1)      // Điểm click thuộc hình chữ nhật
            {
                if (obj.p1.X < p.X && obj.p2.X > p.X && obj.p1.Y < p.Y && obj.p2.Y > p.Y || obj.p1.X > p.X && obj.p2.X < p.X && obj.p1.Y > p.Y && obj.p2.Y < p.Y) 
                    return true;
            }
            return false;
        }

        private void ptbDraw_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            for ( int i = 0; i < lstObj.Count; i ++ )
            {
                if ( Find_Point(lstObj[i], e.Location) == true )
                {               
                    if ( lstObj[i].type == 1 )
                    {          
                        RichTextBox txt = new RichTextBox();
                        ptbDraw.Controls.Add(txt);
                        txt.Visible = true;
                        txt.Location = new Point(lstObj[i].p1.X + 2, lstObj[i].p1.Y + 2);
                        int cr = Math.Abs(lstObj[i].p1.X - lstObj[i].p2.X);
                        int cc = Math.Abs(lstObj[i].p1.Y - lstObj[i].p2.Y);
                        txt.Size = new Size(cr - 3 , cc - 3);
                        txt.Text = "Ghi nội dung của Topic";
                        txt.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
                        txt.SelectionAlignment = HorizontalAlignment.Center;
                        txt.BorderStyle = BorderStyle.None;                     
                    }    
                }    
            }    
        }

        private void btnSubTopic_Click(object sender, EventArgs e)
        {
            myObj = new Eclipse();
            myObj.type = 2;
            isPress = true;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ptbDraw_Click(object sender, EventArgs e)
        {
            Draw_Initialize();
        }

        private void ptbDraw_MouseDown(object sender, MouseEventArgs e)
        {
            if ( isPress)
            {
                myObj.p1 = e.Location;
                myObj.myColor = myColor;
                myObj.mySize = 2;
                myObj.myPen = myPen;
                myObj.myBrush = myBrush;

                this.lstObj.Add(myObj);

                myObj.p2 = new Point( myObj.p1.X+150,myObj.p1.Y+100);
                myObj.init();
                myObj.Draw(this.g1, this.lstObj[1].myPen, this.lstObj[1].myColor);
                g1.DrawImage(bm, 0, 0);
            }
        }

        private void btnRelationship_Click(object sender, EventArgs e)
        {
            DrawObject cv = new Curve();
            isPress = true;
        }

        private void outlinerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucOutliner1.Show();
            ucOutliner1.BringToFront();
        }

        private void mindMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucOutliner1.Hide();
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
