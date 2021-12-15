using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace task4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        struct elementInfo
        {
            public int atomic;
            public string name;
        }

        struct lineInfo
        {
            public float wlen;
            public float intens;
        }

        List<elementInfo> elements = new List<elementInfo> ();
        List<lineInfo> line = new List<lineInfo> ();
        SqlConnection con;
        Pen pen = new Pen(Color.White);

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.Black);

            int w = pictureBox1.Width;
            int h = pictureBox1.Height;
            
            float[] c = new float[3];
            for(int i = 0; i < line.Count; i++)
            {
                float x = interp.map(line[i].wlen, 380.0f, 780.0f, 0, w);
                

                Wavelen.nm2rgb(line[i].wlen, c);

                pen.Color = Color.FromArgb((int)(c[0]), (int)(c[1]), (int)(c[2]));
               

                e.Graphics.DrawLine(pen, x, 0, x, h);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idx = comboBox1.SelectedIndex;
            if (idx < 0) return;

            int atomic = elements[idx].atomic;

            
            string sql = "SELECT wavelenght, rel_intensy FROM spectral_lines ";
            sql += "WHERE atomic_number = " + atomic.ToString();
            SqlCommand cmd = new SqlCommand(sql, con);

            SqlDataReader rdr = cmd.ExecuteReader();

            int col_wlen = rdr.GetOrdinal("wavelenght");
            int col_reli = rdr.GetOrdinal("rel_intensy");

            line.Clear ();
            while(rdr.Read())
            {
                lineInfo li;
                li.wlen = (float)rdr.GetDouble(col_wlen);
                li.intens = (float)rdr.GetDouble (col_reli);
                richTextBox1.Text = "Element name:" + elements[idx].name + "\nElement atomic number:" + elements[idx].atomic + "\nWave lenght: " + li.wlen + "\nLine intens: " + li.intens ;
                line.Add (li);
            }
            rdr.Close();
           

            pictureBox1.Invalidate();
        }

        
        Size dif_size;
        Size form_size;
        Size pic_size;
        private void Form1_Load(object sender, EventArgs e)
        {
            form_size = this.Size;
            pic_size = pictureBox1.Size;
            dif_size = form_size - pic_size;

            string constr =
                @"Data Source=LAPTOP-38K6OPT4\SQLEXPRESS;" +
                "Initial Catalog=lab04;" +
                "Integrated Security=True;";
    
            con = new SqlConnection(constr);
            con.Open();

            string sql = "SELECT atomic_number, full_name FROM elements";
            SqlCommand cmd = new SqlCommand(sql, con);

            SqlDataReader rdr = cmd.ExecuteReader();

            int col_atom = rdr.GetOrdinal("atomic_number");
            int col_name = rdr.GetOrdinal("full_name");
           
            
            while (rdr.Read())
            {
                elementInfo el;
                el.atomic = rdr.GetInt32(col_atom);
                el.name = rdr.GetString(col_name);

                elements.Add(el);
                comboBox1.Items.Add(el.name);
            }
            rdr.Close();

           
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            form_size = this.Size;
            pic_size = form_size - dif_size;
            pictureBox1.Size = pic_size;
            pictureBox1.Invalidate();


        }
    }
}
