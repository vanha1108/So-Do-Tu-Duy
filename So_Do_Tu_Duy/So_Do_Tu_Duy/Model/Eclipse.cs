using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace So_Do_Tu_Duy
{
    public class Eclipse : DrawObject
    {
        public Eclipse(int idObj, string name, Point point, int witdh, int height):base(idObj, name, point, witdh, height)
        { }

        public override void Draw(Graphics myGp, Pen myPen )
        {
            myGp.DrawEllipse(myPen, base.Point.X, base.Point.Y, base.Witdh, base.Height);
        }
    }
}
