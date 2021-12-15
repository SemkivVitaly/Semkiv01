using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace task1
{
    internal class Circle : Figure
    {
        public float radius;
        public float squareRadius;
        public float diametr;
        
        static int lastNumber = 0;
        public int Nomer { get; }

        public void setRadius()
        {
            radius = setX;
            squareRadius = radius*radius;
            diametr = radius * 2.0f;
        }
      
        public Circle()
        {
            lastNumber++;
            Nomer = lastNumber;
        }

        public override string setName()
        {
            nameFigure = nameFigure.ToString() + Nomer.ToString();
            return nameFigure;


        }


        public override bool test(float x, float y)
        {
            float dx = x - pos_x;
            float dy = y - pos_y;
            if (dx * dx + dy * dy <= squareRadius) return true;
            return false;
        }

        public override void draw(Graphics g)
        {
            setRadius();
            float x0 = pos_x - radius;
            float y0 = pos_y - radius;
            Pen p = Pens.Black;
            if (selected == true) p = Pens.Red;
            g.DrawEllipse(p, x0,y0, diametr,diametr);
        }


    }
}
