﻿using System;
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
        public int IdObj;

        public string Name;

        public Point Point = new Point(0, 0);

        public Point P2;

        public int Witdh;

        public int Height;

        public DrawObject()
        {

        }

        public DrawObject ( int idObj, string name, Point point, int witdh, int height)
        {
            IdObj = idObj; 
            Name = name;
            Point = point;
            Witdh = witdh;
            Height = height;
        }

        public DrawObject(int idObj, string name, Point point, Point p2, int witdh, int height)
        {
            IdObj = idObj;
            Name = name;
            Point = point;
            P2 = p2;
            Witdh = witdh;
            Height = height;
        }

        public abstract void Draw(Graphics myGp, Pen myPen);
    }
}
