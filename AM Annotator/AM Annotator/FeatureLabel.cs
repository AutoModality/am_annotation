﻿using System.Collections.Generic;
using System.Drawing;

namespace AM_Annotator
{
    public class FeatureLabel
    {
        private int _id;
        private int _x;
        private int _y;
        private int _w;
        private int _h;
        private int _ex;
        private int _ey;
        private Point _e;
        private Point _b;
        private Point _d;
        private int _cx;
        private int _cy;
        private double _rcx;
        private double _rcy;
        private double _rw;
        private double _rh;

        public int Id { get{ return _id; } set{ _id = value; } }
        public int X { get { return _x; } set { _x = value; } }
        public int Y { get { return _y; } set { _y = value; } }
        public int Width { get { return _w; } set { _w = value; } }
        public int Height { get { return _h; } set { _h = value; } }
        public int End_X { get { return _ex; } set { _ex = value; } }
        public int End_Y { get { return _ey; } set { _ey = value; } }
        public int C_X { get { return _cx; } set { _cx = value; } }
        public int C_Y { get { return _cy; } set { _cy = value; } }
        public double RC_X { get { return _rcx; } set { _rcx = value; } }
        public double RC_Y { get { return _rcy; } set { _rcy = value; } }
        public double RWidth { get { return _rw; } set { _rw = value; } }
        public double RHeight { get { return _rh; } set { _rh = value; } }
        public Point End { get { return _e; } set { _e = value; } }
        public Point Begin { get { return _b; } set { _b = value; } }
        public Point Dimension { get { return _d; } set { _d = value; } }

        /*Constructors*/
        public FeatureLabel()
        {

        }

        public FeatureLabel(int id, int x, int y, int width, int height)
        {
            _id = id;
            _x = x;
            _y = y;
            _w = width;
            _h = height;
            _ex = X + Width;
            _ey = Y + Height;
            _cx = x + width / 2;
            _cy = y + height / 2;

            _d = new Point(Width, Height);
            _b = new Point(X, Y);
            _e = new Point(End_X, End_Y);
        }
        public FeatureLabel(int id, Rectangle rect)
        {
            _id = id;
            _x = rect.X;
            _y = rect.Y;
            _w = rect.Width;
            _h = rect.Height;
            _ex = rect.X + rect.Width;
            _ey = rect.Y + rect.Height;
            _cx = rect.X + rect.Width / 2;
            _cy = rect.Y + rect.Height / 2;


        _d = new Point(rect.Width, rect.Height);
            _b = new Point(rect.X, rect.Y);
            _e = new Point(_ex, _ey);
        }

        /*Utilities*/
        public static FeatureLabel FromString(string src)
        {
            string src_trim = src.Trim(' ');
            string[] values = src_trim.Split(',');
            FeatureLabel fl = new FeatureLabel(System.Convert.ToInt32(values[0]), System.Convert.ToInt32(values[1]), 
                System.Convert.ToInt32(values[2]), System.Convert.ToInt32(values[3]), System.Convert.ToInt32(values[4]));
            return fl;
        }
            
        /*Returns*/
        public Rectangle getAnnotation()
        {
            return new Rectangle(X, Y, Width, Height);
        }
        
        override
        public string ToString()
        {
            return Id.ToString() + ", " + X.ToString() + ", " + Y.ToString() + ", " + Width.ToString() + ", " + Height.ToString();
        }
    }
}