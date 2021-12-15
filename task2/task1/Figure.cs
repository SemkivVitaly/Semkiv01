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

namespace task2
{
    public class Figure
    {
        public Vec2 pos = new Vec2();
        public RGB color = RGB.getRandom(); //а будет ли работать?
        public bool selected;
        public int numInList; 
        public float setX;
        public string nameFigure;
        

        virtual public bool test(float x, float y)
        {
            return false;
        }

        virtual public void draw(Graphics g)
        {
            
        }

        virtual public string setName()
        {
            return nameFigure;
        }

        virtual public float sdf(Vec2 p)
        {
            float innerD = 0; float outerD = 0;
            return innerD + outerD;
        }


    }
}
