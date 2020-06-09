using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace So_Do_Tu_Duy
{
    class Curve : DrawObject
    {
        public Curve()
        {
        }

        public Curve(Point p1, Point p2)
        {
            base.p1 = p1;
            base.p2 = p2;
        }
        public override void Draw(Graphics myGp, Pen myPen, Color myColor)
        {
            myPen.DashStyle = DashStyle.Solid;
          
            Point[] curvePoints = { p1, p2 };
            myGp.DrawCurve(myPen, curvePoints);
        }
    }
}
