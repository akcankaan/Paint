using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASE
{
    class Sekiller
    {
        public int x { get; set; }
        public int y { get; set; }
        public Color Sekilrengi { get; set; }
        public virtual void BitisAta (int bx, int by) { } 
        public virtual void Ciz(Graphics ciz) { }
        public virtual bool Icindemi(int x, int y) { return false; }
        public virtual void SinirCiz(Graphics ciz) { }

        public List<Sekiller> sekillers = new List<Sekiller>();

        public List<Point> points = new List<Point>();
    }

    

    class Kare:Sekiller
    {
        private int width;
        public int Width
        {
            get { return width; }
            set 
            {
                if (value<0)
                {
                    value = 0;
                } 
                else if(value>0&&value<100)
                {
                    value = width;
                }
            }
        }
        public Kare ()
        {
            width = 0;
        }
        public override void BitisAta(int bx, int by)
        {
            width = bx - x;
        }
        public override bool Icindemi(int x, int y)
        {
            if (this.x + width >= x && this.y + width >= y && this.x <= x && this.y <= y)
            {
                return true;
            }
            return false;
        }
        public override void Ciz(Graphics ciz)
        {
            ciz.FillRectangle(new SolidBrush(Sekilrengi), x, y, Width, Width);
        }
        public override void SinirCiz(Graphics ciz)
        {
            ciz.DrawRectangle(Pens.Blue, x, y, Width, Width);
        }
    }
    
    class Daire:Sekiller
    {
        private int yari_cap;
        public override void BitisAta(int bx, int by)
        {
            yari_cap = bx - x;
        }
        public override void Ciz(Graphics ciz)
        {
            ciz.FillEllipse(new SolidBrush(Sekilrengi), x, y, yari_cap, yari_cap);
        }
        public override void SinirCiz(Graphics ciz)
        {
            ciz.DrawRectangle(Pens.Blue, x, y, yari_cap, yari_cap);
        }
        public override bool Icindemi(int x, int y)
        {
            int dx = Math.Abs(yari_cap + x);
            int dy = Math.Abs(yari_cap + y);
            int b = Math.Abs(dx - yari_cap);
            double a = Math.Abs(Math.Sqrt((dx * dx) + (dy * dy) - yari_cap));
            if (this.yari_cap + a >= yari_cap && this.yari_cap + b >= yari_cap && this.x <= x && this.y <= y)
            {
                return true;
            }
            return false;
        }
    }

    class Ucgen:Sekiller
    {
        Point[] ucgen = new Point[3];
        public Point p1 { get; set; }
        public Point p2 { get; set; }
        public Point p3 { get; set; }
        public override void BitisAta(int bx, int by)
        {
            int dx = Math.Abs(bx - x);
            int dy = Math.Abs(by - y);
            p1 = new Point(x, y);
            p2 = new Point(bx, by);
            p3 = new Point(x - dx, y + dy);
            ucgen[0] = p1;
            ucgen[1] = p2;
            ucgen[2] = p3;
        }
        public override bool Icindemi(int x, int y)
        {

            if (this.x < x && this.y < y && this.x < x && this.y < y)
            {
                return true;
            }
            return false;
        }
        public override void SinirCiz(Graphics ciz)
        {
            ciz.DrawPolygon(Pens.Blue, ucgen);
        }
        public override void Ciz(Graphics ciz)
        {
            ciz.FillPolygon(new SolidBrush(Sekilrengi), ucgen);
        }
    }

    class Altigen:Sekiller
    {
        Point[] altigen = new Point[6];
        public Point p1 { get; set; }
        public Point p2 { get; set; }
        public Point p3 { get; set; }
        public Point p4 { get; set; }
        public Point p5 { get; set; }
        public Point p6 { get; set; }

        public override void BitisAta(int bx, int by)
        {
            int dx = Math.Abs(bx / 4);
            int dy = Math.Abs(by / 3);
            p1 = new Point(x + (2 * dx), y);
            p2 = new Point(x + dx, y - dy);
            p3 = new Point(x - dx, y - dy);
            p4 = new Point(x - (2 * dx), y);
            p5 = new Point(x - dx, y + dy);
            p6 = new Point(x + dx, y + dy);
            altigen[0] = p1;
            altigen[1] = p2;
            altigen[2] = p3;
            altigen[3] = p4;
            altigen[4] = p5;
            altigen[5] = p6;
        }
        public override bool Icindemi(int x, int y)
        {
            if (this.x < x && this.y < y && this.x < x && this.y < y)
            {
                return true;
            }

            return false;
        }
        public override void SinirCiz(Graphics ciz)
        {
            ciz.DrawPolygon(Pens.Blue, altigen);
        }
        public override void Ciz(Graphics ciz)
        {
            ciz.FillPolygon(new SolidBrush(Sekilrengi), altigen);
        }
    }
}
