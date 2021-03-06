﻿using System;
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
        //public Point p2 = new Point(0, 0);
        public Curve(int idObj, string name, Point point, int witdh, int height):base(idObj, name, point,witdh,height)
        {
        }

        public Curve(int idObj, string name, Point point, Point p2 , int witdh, int height) : base(idObj, name, point, p2, witdh, height)
        {
        }

        public override void Draw(Graphics myGp, Pen myPen)
        {

            myGp.DrawBezier(myPen, base.Point, new Point(base.Point.X + 20, base.Point.Y + 20), new Point(base.Point.X + 20, base.Point.Y + 20)
                ,base.P2);

        }
    }
}
