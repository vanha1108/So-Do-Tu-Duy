using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace So_Do_Tu_Duy
{
    class SubTopic : DrawObject
    {
        List<Eclipse> lstElip = new List<Eclipse>();
        List<Curve> lstCur = new List<Curve>();
        public SubTopic()
        {
            isSelect = true;
        }
        public SubTopic(Point p1, Point p2)
        {
            base.p1 = p1;
            base.p2 = p2;
        }
        public override void Draw(Graphics myGp, Pen myPen, Color myColor)
        {
            myGp.DrawEllipse(myPen, this.p1.X, this.p1.Y, this.p2.X - this.p1.X, this.p2.Y - this.p1.Y);
            if ( isFill == true) myGp.FillEllipse(myBrush, this.p1.X, this.p1.Y, this.p2.X - this.p1.X, this.p2.Y - this.p1.Y);
        }
    }
}
