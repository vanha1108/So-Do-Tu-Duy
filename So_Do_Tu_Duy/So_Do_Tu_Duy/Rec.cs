using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace So_Do_Tu_Duy
{
    class Rec : DrawObject
    {
        public Rec()
        {
        }
        public Rec(Point p1, Point p2)
        {
            base.p1 = p1;
            base.p2 = p2;
        }
        public override void Draw(Graphics myGp, Pen myPen, Color myColor)
        {
            myPen.DashStyle = DashStyle.Solid;

            int x = Math.Min(this.p1.X, this.p2.X);
            int y = Math.Min(this.p1.Y, this.p2.Y);
            int width = Math.Abs(this.p1.X - this.p2.X);
            int height = Math.Abs(this.p1.Y - this.p2.Y);
            Rectangle _rect = new Rectangle(x, y, width, height);
            myGp.DrawRectangle(myPen, _rect);
            if (isFill == true) myGp.FillRectangle(myBrush, _rect);
        }
    }
}
