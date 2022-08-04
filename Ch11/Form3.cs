using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch11
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();

            Brush redbrush = new SolidBrush(Color.Red);
            Pen blackpen = new Pen(Color.Black);

            Rectangle rect = new Rectangle(10, 80, 100, 100);
            g.DrawRectangle(blackpen, rect);
            g.FillRectangle(redbrush, rect);

        
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();

            Brush bluebrush = new SolidBrush(Color.Blue);
            Pen blackpen = new Pen(Color.Black);

            Rectangle rect = new Rectangle(120, 80, 100, 100);
            g.DrawEllipse(blackpen, rect);
            g.FillEllipse (bluebrush, rect);

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();

            Pen blackpen = new Pen(Color.Black);

            g.DrawLine(blackpen, new Point(230,180),new Point(430,180));

        }
    }
}
