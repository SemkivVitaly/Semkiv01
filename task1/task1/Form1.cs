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

namespace task1
{
    public partial class Form1 : Form
    {
        int old_x, old_y;
        bool shiftpress = false;
        string s;
        int g;
        List<Figure> lst = new List<Figure> ();
        


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
            e.Graphics.FillRectangle(Brushes.White, 0, 0, pictureBox1.Width, pictureBox1.Height);
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
                    fig.pos_x += dx;
                    fig.pos_y += dy;
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
                        fig.selected = fig.test(lst[i].pos_x, lst[i].pos_y);
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
            if (e.Shift == true)
            {
                shiftpress = false;
                listBoxMain.ClearSelected();
                listBoxMain.SelectedIndex = 0;
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

        private void addbutton_Click(object sender, EventArgs e)
        {
            Figure fig = createFigure(comboBoxMain.Text);
            
            if (fig == null) return;           
            fig.pos_x = pictureBox1.Width / 2;
            fig.pos_y = pictureBox1.Height / 2;
            fig.nameFigure = comboBoxMain.Text;         
            fig.setX = (float) Convert.ToDouble(textBoxSetX.Text);
            pictureBox1.Invalidate();
            fig.setName();
            lst.Add(fig);
            listBoxMain.Items.Add(fig.nameFigure);
            

        }
    }
}
