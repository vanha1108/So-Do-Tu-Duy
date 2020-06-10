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
        public Curve(string name, Point point, int witdh, int height):base(name, point,witdh,height)
        {
        }


        public override void Draw(Graphics myGp, Pen myPen)
        {
            

        }
    }
}
