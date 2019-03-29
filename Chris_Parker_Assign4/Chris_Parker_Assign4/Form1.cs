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
        private static Pen selectedPen;
        private static int xMax = 10;
        private static int xMin = -10;
        private static int yMax = 10;
        private static int yMin = -10;

        public Form1()
        {
            InitializeComponent();

            whitePen = new Pen(Color.White);
            selectedPen = new Pen(Color.White);

            string[] colors = { "White", "Red", "Green", "Blue" };
            linearColor.DataSource = colors;
            linearColor.BindingContext = new BindingContext();
            quadColor.DataSource = colors;
            quadColor.BindingContext = new BindingContext();
            cubicColor.DataSource = colors;
            cubicColor.BindingContext = new BindingContext();
            circleColor.DataSource = colors;
            circleColor.BindingContext = new BindingContext();

        }

        private void DrawAxes(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            //Horizontal Axis
            g.DrawLine(whitePen, 0, ( Math.Abs(yMin) * CoordinatePlane.Height / (Math.Abs(yMin) + Math.Abs(yMax))), CoordinatePlane.Width, (Math.Abs(yMin) * CoordinatePlane.Height / (Math.Abs(yMin) + Math.Abs(yMax))));
            //Vertical Axis
            g.DrawLine(whitePen, (Math.Abs(xMin) * CoordinatePlane.Width / (Math.Abs(xMin) + Math.Abs(xMax))), 0, (Math.Abs(xMin) * CoordinatePlane.Width / (Math.Abs(xMin) + Math.Abs(xMax))), CoordinatePlane.Height);

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = Header;

            linearColor.SelectedIndex = -1;
            quadColor.SelectedIndex = -1;
            cubicColor.SelectedIndex = -1;
            circleColor.SelectedIndex = -1;
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
            Graphics g = CoordinatePlane.CreateGraphics();


            if ((string)linearColor.SelectedValue == "White")
            {
                selectedPen = new Pen(Color.White);
            }
            else if ((string)linearColor.SelectedValue == "Red")
            {
                selectedPen = new Pen(Color.Red);
            }
            else if ((string)linearColor.SelectedValue == "Green")
            {
                selectedPen = new Pen(Color.Green);
            }
            else if ((string)linearColor.SelectedValue == "Blue")
            {
                selectedPen = new Pen(Color.Blue);
            }

            int m = Convert.ToInt32(linearM.Text);
            int b = Convert.ToInt32(linearB.Text);
            //Finding x1 and x2
            int result = (m * xMin) + b;
            int x1 = 0;
            int x2 = 0;
            int y1 = 0;
            int y2 = 0;

            //PointF point1 = new PointF(x1, y1);
            //PointF point2 = new PointF(x2, y2);

            //g.DrawLine(selectedPen, point1, point2);
            



            if (m < 0)
            {
                for (x1 = xMin; result > yMax; x1++)
                {
                    result = (m * x1) + b;
                }

                x1--;

                x1 = Math.Abs(xMin - x1);

                if ((m * xMin + b) == yMax)
                {
                    y1 = 0;
                    x1 = 0;
                }

                if ((m * xMin + b) < yMax)
                {
                    x1 = 0;
                    y1 = Math.Abs(yMax - result);
                }
                else
                {
                    y1 = 0;
                }

                result = (m * xMax) + b;
                

                for (x2 = xMax; result < yMin; x2--)
                {
                    result = (m * x2) + b;
                }

                x2++;

                if ((m * xMax + b) == yMin)
                {
                    y2 = Math.Abs(yMin) + Math.Abs(yMax);
                    x2 = Math.Abs(xMin) + Math.Abs(xMax);
                }

                if ((m * xMax + b) > yMin)
                {
                    x2 = Math.Abs(xMin) + Math.Abs(xMax);
                    y2 = Math.Abs(yMax) + Math.Abs(result);
                }
                else
                {
                    x2 = Math.Abs(xMin) + x2;
                    y2 = Math.Abs(yMin) + Math.Abs(yMax);
                }
                //Found x1 and x2
            }

            else
            {
                for (x1 = xMin; result > yMin; x1++)
                {
                    result = (m * x1) + b;
                }

                x1--;

                x1 = Math.Abs(xMin + x1);

                if ((m * xMin + b) == yMax)
                {
                    y1 = 0;
                    x1 = 0;
                }

                if ((m * xMin + b) < yMax)
                {
                    x1 = 0;
                    y1 = Math.Abs(yMax - result);
                }
                else
                {
                    y1 = 0;
                }

                result = (m * xMax) + b;
                
                for (x2 = xMax; result < yMax; x2--)
                {
                    result = (m * x2) + b;
                }

                x2++;

                if ((m * xMax + b) == yMin)
                {
                    y2 = Math.Abs(yMin) + Math.Abs(yMax);
                    x2 = Math.Abs(xMin) + Math.Abs(xMax);
                }

                if ((m * xMax + b) > yMin)
                {
                    x2 = Math.Abs(xMin) + Math.Abs(xMax);
                    y2 = Math.Abs(yMax) + Math.Abs(result);
                }
                else
                {
                    x2 = Math.Abs(xMin) + x2;
                    y2 = Math.Abs(yMin) + Math.Abs(yMax);
                }
                //Found x1 and x2
            }


            int denominator1 = Math.Abs(xMin) + Math.Abs(xMax);
            int denominator2 = Math.Abs(yMin) + Math.Abs(yMax);

            g.DrawLine(selectedPen, (Math.Abs(x1) * CoordinatePlane.Width / denominator1), (Math.Abs(y1) * CoordinatePlane.Height / denominator2),
                      (Math.Abs(x2) * CoordinatePlane.Width / denominator1), (Math.Abs(y2) * CoordinatePlane.Height / denominator2));
                      
        }

        private void quadGraph(object sender, EventArgs e)
        {

        }

        private void cubicGraph(object sender, EventArgs e)
        {

        }

        private void circleGraph(object sender, EventArgs e)
        {
            Graphics g = CoordinatePlane.CreateGraphics();

            if ((string)circleColor.SelectedValue == "White")
            {
                selectedPen = new Pen(Color.White);
            }
            else if ((string)circleColor.SelectedValue == "Red")
            {
                selectedPen = new Pen(Color.Red);
            }
            else if ((string)circleColor.SelectedValue == "Green")
            {
                selectedPen = new Pen(Color.Green);
            }
            else if ((string)circleColor.SelectedValue == "Blue")
            {
                selectedPen = new Pen(Color.Blue);
            }            

            float scale = 600 / 20;
            float h = Convert.ToInt32(circleH.Text)*scale;
            float k = Convert.ToInt32(circleK.Text)*scale;
            double tempR = Convert.ToInt32(circleR.Text);
            float r = (float)Math.Sqrt(tempR)*scale; 

            g.DrawEllipse(selectedPen, h+(10*scale)-r, (scale*10)-k-r, r*2,r*2);
            
        }

        private void clearGraph(object sender, EventArgs e)
        {
            Graphics g = CoordinatePlane.CreateGraphics();

            SolidBrush paintItBlack = new SolidBrush(Color.Black);
            g.FillRectangle(paintItBlack, 0, 0, CoordinatePlane.Width, CoordinatePlane.Height);

            //Horizontal Axis
            g.DrawLine(whitePen, 0, (Math.Abs(yMin) * CoordinatePlane.Height / (Math.Abs(yMin) + Math.Abs(yMax))), CoordinatePlane.Width, (Math.Abs(yMin) * CoordinatePlane.Height / (Math.Abs(yMin) + Math.Abs(yMax))));
            //Vertical Axis
            g.DrawLine(whitePen, (Math.Abs(xMin) * CoordinatePlane.Width / (Math.Abs(xMin) + Math.Abs(xMax))), 0, (Math.Abs(xMin) * CoordinatePlane.Width / (Math.Abs(xMin) + Math.Abs(xMax))), CoordinatePlane.Height);
        }

        private void linearMTxtChange(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(linearM.Text, "  ^ [0-9]"))
            {
                linearM.Text = "";
            }
        }

        private void linearMKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void linearBTxtChange(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(linearB.Text, "  ^ [0-9]"))
            {
                linearB.Text = "";
            }
        }

        private void linearBKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void quadATxtChange(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(quadA.Text, "  ^ [0-9]"))
            {
                quadA.Text = "";
            }
        }

        private void quadAKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void quadBTxtChange(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(quadB.Text, "  ^ [0-9]"))
            {
                quadB.Text = "";
            }
        }

        private void quadBKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void quadCTxtChange(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(quadC.Text, "  ^ [0-9]"))
            {
                quadC.Text = "";
            }
        }

        private void quadCKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void cubicA_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(cubicA.Text, "  ^ [0-9]"))
            {
                cubicA.Text = "";
            }
        }

        private void cubicA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void cubicB_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(cubicB.Text, "  ^ [0-9]"))
            {
                cubicB.Text = "";
            }
        }

        private void cubicB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void cubicC_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(cubicC.Text, "  ^ [0-9]"))
            {
                cubicC.Text = "";
            }
        }

        private void cubicC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void cubicD_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(cubicD.Text, "  ^ [0-9]"))
            {
                cubicD.Text = "";
            }
        }

        private void cubicD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void circleH_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(circleH.Text, "  ^ [0-9]"))
            {
                circleH.Text = "";
            }
        }

        private void circleH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void circleK_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(circleK.Text, "  ^ [0-9]"))
            {
                circleK.Text = "";
            }
        }

        private void circleK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void circleR_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(circleR.Text, "  ^ [0-9]"))
            {
                circleR.Text = "";
            }
        }

        private void circleR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void xMinChanged(object sender, EventArgs e)
        {
            int min = Convert.ToInt32(xMinRange.Value); //gets int from num up down
            int max = Convert.ToInt32(xMaxRange.Value); //gets int from num up down

            if (min > max)
            {
                xMaxRange.Value = xMinRange.Value; //if min>max set max = min
            }
        }

        private void xMaxChanged(object sender, EventArgs e)
        {
            int min = Convert.ToInt32(xMinRange.Value); //gets int from num up down
            int max = Convert.ToInt32(xMaxRange.Value); //gets int from num up down

            if (max < min)
            {
                xMinRange.Value = xMaxRange.Value; //if min>max set min = max
            }
        }

        private void yMinChanged(object sender, EventArgs e)
        {
            int min = Convert.ToInt32(yMinRange.Value); //gets int from num up down
            int max = Convert.ToInt32(yMaxRange.Value); //gets int from num up down

            if (min > max)
            {
                yMaxRange.Value = yMinRange.Value; //if min>max set max = min
            }
        }

        private void yMaxChanged(object sender, EventArgs e)
        {
            int min = Convert.ToInt32(yMinRange.Value); //gets int from num up down
            int max = Convert.ToInt32(yMaxRange.Value); //gets int from num up down

            if (min > max)
            {
                yMinRange.Value = yMaxRange.Value; //if min>max set max = min
            }
        }
    }
}
