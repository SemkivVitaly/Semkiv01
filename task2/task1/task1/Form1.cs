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
using Microsoft.VisualBasic;
using System.IO;

namespace task2
{
    public partial class Form1 : Form
    {
        int old_x, old_y;
        bool shiftpress = false;
        string s;
        int g;
        List<Figure> lst = new List<Figure> ();
        Bitmap bmp;

        Figure createFigure(string fig_type)
        {
            switch (fig_type) {
                case "circle": return new Circle();
                case "square": return new Square();
                case "triangle": return new Triangle();
            }
            return null;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Figure fig in lst)
                fig.draw(e.Graphics);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            
            
            if (shiftpress == false)
            foreach (Figure fig in lst)
                fig.selected = false;
           
            for(int i = 0; i <= lst.Count - 1; i++)
            {
               
                Figure fig = lst[i];
                fig.selected = fig.test(e.X, e.Y);

                if (fig.selected == true)
                {
                    if (shiftpress == false)
                    {
                        if (!listBoxMain.SelectedIndex.Equals(g))
                            listBoxMain.SelectedIndex = i;
                        else
                        {
                            listBoxMain.SetSelected(g, false);
                            listBoxMain.SelectedIndex = i;
                            g = listBoxMain.SelectedIndex;
                        }
                    }
                    else
                        listBoxMain.SelectedIndex = i;

                    break;

                }

            }
            pictureBox1.Invalidate();
        }
        
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.X - old_x;
                int dy = e.Y - old_y;
                foreach(Figure fig in lst)
                {
                    if (fig.selected == false) continue;
                    fig.pos.x += dx;
                    fig.pos.y += dy;
                }
                pictureBox1.Invalidate();
            }
            old_x = e.X;
            old_y = e.Y;
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            
            DialogResult res = MessageBox.Show("Вы точно хотите удалить фигуру", "Сообщение", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                if (shiftpress == false)
                {
                    for (int i = 0; i < lst.Count ; i++)
                    {
                       
                        if (lst[i].selected == true) lst.RemoveAt(i);
                        if (listBoxMain.SelectedIndex.Equals(i)) listBoxMain.Items.RemoveAt(i);

                    }
                    pictureBox1.Invalidate();
                }
                
                    if (shiftpress == true)
                    {
                        for (int i = 0; i < lst.Count; i++)
                        {
                            if (listBoxMain.GetSelected(i) == true)
                            {
                                if (lst[i].selected == true) lst.RemoveAt(i);
                                listBoxMain.Items.RemoveAt(i);

                            }

                        }
                    pictureBox1.Invalidate();
                     }
                
            }
            
        }

       

        private void listBoxMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (shiftpress == false)
                foreach (Figure fig in lst)
                    fig.selected = false;

           
            for (int i = 0 ; i <= listBoxMain.Items.Count - 1; i++)
            {

                    if (listBoxMain.GetSelected(i))
                    {
                        Figure fig = lst[i];
                        fig.selected = fig.test(lst[i].pos.x, lst[i].pos.y);
                        if (fig.selected == true)
                        {
                            if(shiftpress == false)
                             break;
                        }

                    }
                
                           
            }
            pictureBox1.Invalidate();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift == true)
                shiftpress = true;

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Shift == false)
            {
                shiftpress = false;
                listBoxMain.ClearSelected();
                //listBoxMain.SelectedIndex = 0;
                g = 0;
            }

        }

        private void listBoxMain_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int i = 0, j = 0;
            s = Interaction.InputBox("Введите новое имя фигуры", "Переименование");
            if (e.Button == MouseButtons.Left)
            {
                while (i < listBoxMain.Items.Count - 1)
                {
                    if (listBoxMain.SelectedIndex.Equals(i))
                    {
                        while (j < listBoxMain.Items.Count - 1)
                        {
                            if (s != "" && !s.Contains(" "))
                            {

                                if (!listBoxMain.Items.Contains(s))
                                {
                                    listBoxMain.Items.RemoveAt(i);
                                    listBoxMain.Items.Insert(i, s);
                                    break;
                                }
                                else
                                {
                                    MessageBox.Show("Такое имя уже сущетсвует");
                                    break;
                                }

                            }
                            else
                            {
                                MessageBox.Show("Имя фигуры не может быть пустым");
                                break;
                            }
                            j++;
                        }

                    }
                    i++;
                }
                
            }
        }

        private void buttonColorSet_Click(object sender, EventArgs e)
        {
            //Provide the ability to select a color
            //for each object using the graphical interface.
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = false;
            MyDialog.ShowHelp = true;
            if (MyDialog.ShowDialog() == DialogResult.OK)
                for (int i = 0; i < lst.Count; i++)
                {

                    if (lst[i].selected == true)
                    {
                    lst[i].color.r = MyDialog.Color.R;
                    lst[i].color.g = MyDialog.Color.G;
                    lst[i].color.b = MyDialog.Color.B;
                    }
                }
        }

        void buttonRender_Click_1(object sender, EventArgs e)
        {
            if (radioLights.Checked)
            {
                for (int y = 0; y < pictureBox1.Height; y++)
                {
                    for (int x = 0; x < pictureBox1.Width; x++)
                    {
                       
                            RGB c = new RGB();

                            Vec2 p = new Vec2(x, y);
                            float ed = 0.01F;
                            float dmin = 100.0F;
                            //ищем ближайшую фигуру к точке
                            foreach (Figure fig in lst)
                            {
                                //if (!fig.test(x, y))
                                {
                                    float d = fig.sdf(p);
                                    //if (d < dmin) //если точка не дальше чем на d от фигуры
                                    {

                                        dmin = d; //меняем d на расстоник точки до фигуры
                                                  //c = fig.color; //меняем цвет точки на цвет (ближайшей) фигуры
                                        float k = (4.0F / (float)(Math.Pow(d, 0.45)));
                                        c += fig.color * k;
                                    }
                                }
                            }
                            foreach (Figure fig in lst)
                            {
                                if (fig.test(x, y))
                                {
                                    c = fig.color;
                                }
                            }

                            bmp.SetPixel(x, y, c.getColor());
                    }
                }
                    pictureBox1.Invalidate();
                
            }
            if (radioNorml.Checked)
            {
                Random rnd = new Random();
                for (int y = 0; y < pictureBox1.Height; y++)
                {
                    for (int x = 0; x < pictureBox1.Width; x++)
                    {
                        Vec2 p = new Vec2(x, y);
                        RGB c = new RGB();

                        int rays = 8;
                        int steps = 8;
                        float err = 3.0f;
                        for (int i = 0; i < rays; i++)
                        {
                            float a = (float)rnd.NextDouble() * 2.0F * (float)Math.PI;

                            Ray r = new Ray(new Vec2(x, y), Vec2.fromPolar(a));//
                            float dm = 1000.0f;
                            float dmax = dm;
                            Figure hit = null;
                            for (int j = 0; j < steps; j++)
                            {
                                foreach (Figure fig in lst)
                                {
                                    float d = fig.sdf(r.org);
                                    if (d > dmax) break;
                                    if (d < dm)
                                    {
                                        dm = d;
                                        hit = fig;
                                        if (dm < err) break;
                                    }
                                }
                                r.org = r.pointAtDistance(dm);
                            }
                            if (dm < err) c = c + hit.color;

                        }
                        c = c * (1.0f / rays);

                        bmp.SetPixel(x, y, c.getColor());
                    }
                }
                pictureBox1.Invalidate();
                 
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bmp;
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            Figure fig = createFigure(comboBoxMain.Text);
            
            if (fig == null) return;           
            fig.pos.x = pictureBox1.Width / 2;
            fig.pos.y = pictureBox1.Height / 2;
            fig.nameFigure = comboBoxMain.Text;         
            fig.setX = (float) Convert.ToDouble(textBoxSetX.Text);
            pictureBox1.Invalidate();
            fig.setName();
            lst.Add(fig);
            listBoxMain.Items.Add(fig.nameFigure);
            

        }
    }
}
