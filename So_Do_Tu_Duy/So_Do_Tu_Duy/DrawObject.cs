using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace So_Do_Tu_Duy
{
    public abstract class DrawObject
    {
        public Point p1 = new Point(0, 0);
        public Point p2 = new Point(0, 0);
        public Color myColor;
        public int mySize;
        public Pen myPen;
        public SolidBrush myBrush;
        public int type = 0;
        public System.Drawing.Drawing2D.DashStyle style;
        public int typeBrush;                       // kiểu nét vẽ
        public bool isSelect = false;               // chưa được chọn
        public bool isFill = false;                 // chưa được tô màu

        public void init()
        {
            myPen.Color = this.myColor;
            myPen.Width = this.mySize;
        }

        public Pen choosePen(int x)
        {
            if (type == 0)
            {
                myPen.DashStyle = DashStyle.Solid;
            }
            else if (type == 1)
            {
                myPen.DashStyle = DashStyle.Dot;
            }
            else if (type == 2)
            {
                myPen.DashStyle = DashStyle.Dash;
            }
            else if (type == 3)
            {
                myPen.DashStyle = DashStyle.DashDot;
            }
            else if (type == 4)
            {
                myPen.DashStyle = DashStyle.DashDotDot;
            }
            return myPen;
        }

        public abstract void Draw(Graphics myGp, Pen myPen, Color myColor);
    }
}
