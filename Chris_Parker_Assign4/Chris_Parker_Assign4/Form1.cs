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

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = Header;
        }

        private void LinEqHint(object sender, EventArgs e)
        {
            displayBoxBottom.Clear();
            string linHint = "Linear Equations (y = mx + b) where 'm' is the slope and 'b' is the y-intercept";
            displayBoxBottom.Text = linHint;
        }

        private void QuadEqHint(object sender, EventArgs e)
        {
            displayBoxBottom.Clear();
            string linHint = "Quadratic Equations (y = ax^2 + bx + c), where a, b, and c are real number coefficients";
            displayBoxBottom.Text = linHint;
        }

        private void CubEqHint(object sender, EventArgs e)
        {
            displayBoxBottom.Clear();
            string linHint = "Cubic Equations (y = ax^3 + bx^2 + cx + d), where a, b, c, and d are real number coefficients";
            displayBoxBottom.Text = linHint;
        }

        private void CirEqHint(object sender, EventArgs e)
        {
            displayBoxBottom.Clear();
            string linHint = "Circle Equations ((x - h)^2 + (y - k)^2 = r^2 ), where (h, k) is the center of the circle, and r is the radius";
            displayBoxBottom.Text = linHint;
        }

        private void linearGraph(object sender, EventArgs e)
        {

        }

        private void quadGraph(object sender, EventArgs e)
        {

        }

        private void cubicGraph(object sender, EventArgs e)
        {

        }

        private void circleGraph(object sender, EventArgs e)
        {

        }

        private void clearGraph(object sender, EventArgs e)
        {

        }
    }
}
