using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chris_Parker_Assign4
{
    public partial class Form1 : Form
    {
        private static Pen whitePen;

        public Form1()
        {
            InitializeComponent();

            whitePen = new Pen(Color.White);
           
        }

        private void DrawAxes(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            //Horizontal Axis
            g.DrawLine(whitePen, 0, (CoordinatePlane.Height / 2), CoordinatePlane.Width, (CoordinatePlane.Height / 2));
            //Vertical Axis
            g.DrawLine(whitePen, (CoordinatePlane.Width / 2), 0, (CoordinatePlane.Width / 2), CoordinatePlane.Height);
        }
    }
}
