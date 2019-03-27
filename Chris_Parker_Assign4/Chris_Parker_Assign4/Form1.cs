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
        private static int xMax = 10;
        private static int xMin = -10;
        private static int yMax = 10;
        private static int yMin = -10;

        public Form1()
        {
            InitializeComponent();

            whitePen = new Pen(Color.White);           
           
        }

        private void DrawAxes(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            //Horizontal Axis
            g.DrawLine(whitePen, 0, ( Math.Abs(yMin) * CoordinatePlane.Height / (Math.Abs(yMin) + Math.Abs(yMax))), CoordinatePlane.Width, (Math.Abs(yMin) * CoordinatePlane.Height / (Math.Abs(yMin) + Math.Abs(yMax))));
            //Vertical Axis
            g.DrawLine(whitePen, (Math.Abs(xMin) * CoordinatePlane.Width / (Math.Abs(xMin) + Math.Abs(xMax))), 0, (Math.Abs(xMin) * CoordinatePlane.Width / (Math.Abs(xMin) + Math.Abs(xMax))), CoordinatePlane.Height);

            //Finding x1 and x2
            int result = (-2 * xMin) + 3; 
            int x1 = 0;
            int y1 = 0;
            int y2 = 0;

            
            for (x1 = xMin; result > yMax; x1++)
            {
                result = (-2 * x1) + 3;
            }

            x1--;

            x1 = Math.Abs(xMin - x1);

            if (result == yMax)
            {
                y1 = 0;
            }
            else
            {
                x1 = 0;
                y1 = Math.Abs(yMax - result);
            }

            result = (-2 * xMax) + 3;
            int x2 = 0;

            for (x2 = xMax; result < yMin; x2--)
            {
                result = (-2 * x2) + 3;
            }

            if (result == yMin)
            {
                y2 = Math.Abs(yMin) + Math.Abs(yMax); ;
            }
            else
            {
                x2 = Math.Abs(xMin) + Math.Abs(xMax); 
                y2 = Math.Abs(yMax) + Math.Abs(result);
            }
            //Found x1 and x2

            MessageBox.Show(x1.ToString() + " : " + x2.ToString() + " : " + y1.ToString() + " : " + y2.ToString() + " : ");

            int denominator1 = Math.Abs(xMin) + Math.Abs(xMax);
            int denominator2 = Math.Abs(yMin) + Math.Abs(yMax);
            
            g.DrawLine(whitePen, (Math.Abs(x1) * CoordinatePlane.Width / denominator1), (Math.Abs(y1) * CoordinatePlane.Height / denominator2),
                      (Math.Abs(x2) * CoordinatePlane.Width / denominator1), (Math.Abs(y2) * CoordinatePlane.Height / denominator2));
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
