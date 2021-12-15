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
    public class Figure
    {
        public float pos_x, pos_y;
        public bool selected;
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

       


    }
}
