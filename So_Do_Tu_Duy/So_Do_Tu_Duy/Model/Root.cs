using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace So_Do_Tu_Duy
{
    public class Root : DrawObject
    {
        public List<DrawObject> lstObj = new List<DrawObject>();

        public Root() : base()
        {

        }
        public Root(int idObj, string name, Point point, int witdh, int height) : base(idObj, name, point, witdh, height)
        {
        }

        public override void Draw(Graphics myGp, Pen myPen)
        {
            Rectangle _rect = new Rectangle(base.Point.X,base.Point.Y,base.Witdh,base.Height);

            myGp.DrawRectangle(myPen, _rect);

        }
    }
}
