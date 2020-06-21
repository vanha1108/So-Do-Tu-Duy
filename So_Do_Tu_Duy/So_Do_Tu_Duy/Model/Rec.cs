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
        public Rec(int idObj, string name, Point point, int witdh, int height):base(idObj, name, point, witdh, height)
        {
        }

        public override void Draw(Graphics myGp, Pen myPen )
        {
            Rectangle _rect = new Rectangle(base.Point.X, base.Point.Y, base.Witdh, base.Height);
            myGp.DrawRectangle(myPen, _rect);
        }
    }
}
