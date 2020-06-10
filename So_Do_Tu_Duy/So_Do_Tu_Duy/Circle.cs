using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace So_Do_Tu_Duy
{
    public class Circle : DrawObject
    {
        public Circle (string name, Point point, int witdh, int height) : base(name, point, witdh, height)
        {  }
        public override void Draw(Graphics myGp, Pen myPen)
        {
            myGp.DrawEllipse(myPen, base.Point.X, base.Point.Y, base.Witdh, base.Witdh);
        }
    }
}
