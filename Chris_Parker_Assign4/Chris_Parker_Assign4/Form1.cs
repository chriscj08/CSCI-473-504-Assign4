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

        public Form1()
        {
            InitializeComponent();

            whitePen = new Pen(Color.White);
            selectedPen = new Pen(Color.White);

            MakeCheckMarks();
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

        private void MakeCheckMarks ()
        {
            Graphics g = CoordinatePlane.CreateGraphics();

            int xMin = Convert.ToInt16(xMinRange.Value);
            int xMax = Convert.ToInt16(xMaxRange.Value);
            int yMin = Convert.ToInt16(yMinRange.Value);
            int yMax = Convert.ToInt16(yMaxRange.Value);

            int xSpace = Convert.ToInt16(xInterval.Value);
            int ySpace = Convert.ToInt16(yInterval.Value);

            //Draw horizontal tick marks
            for (int i = xMin; i < xMax; i+= xSpace)
            {
                g.DrawLine(whitePen,(float)i * (600 / ((float)yMax - (float)yMin)), 150 + (float)yMax * (600 / ((float)yMax - (float)yMin)), (float)i * (600 / ((float)yMax - (float)yMin)), -150 +(float)yMax * (600 / ((float)yMax - (float)yMin)));
                
            }


        }

        private void DrawAxes(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int xMin = Convert.ToInt16(xMinRange.Value);
            int xMax = Convert.ToInt16(xMaxRange.Value);
            int yMin = Convert.ToInt16(yMinRange.Value);
            int yMax = Convert.ToInt16(yMaxRange.Value);

            int xSpace = Convert.ToInt16(xInterval.Value);
            int ySpace = Convert.ToInt16(yInterval.Value);

            //Draw horizontal tick marks
            for (int i = 0; i < xMax - xMin; i += xSpace)
            {
                g.DrawLine(whitePen, (float)Math.Abs(i) * (600 / ((float)xMax - (float)xMin)), 10 + (float)yMax * (600 / ((float)yMax - (float)yMin)), (float)Math.Abs(i) * (600 / ((float)xMax - (float)xMin)), -10 + (float)yMax * (600 / ((float)yMax - (float)yMin)));

            }

            //Draw vertical tick marks
            for (int i = 0; i < yMax - yMin; i += ySpace)
            {
                g.DrawLine(whitePen, 10 + (float)xMax * (600 / ((float)xMax - (float)xMin)), (float)Math.Abs(i) * (600 / ((float)yMax - (float)yMin)), -10 + (float)xMax * (600 / ((float)xMax - (float)xMin)), (float)Math.Abs(i) * (600 / ((float)yMax - (float)yMin)));

            }

            //Horizontal Axis
            g.DrawLine(whitePen, 0, (float)yMax * (600 / ((float)yMax - (float)yMin)), CoordinatePlane.Width, (float)yMax * (600 / ((float)yMax - (float)yMin)));
            //Vertical Axis
            g.DrawLine(whitePen, (float)Math.Abs(xMin) * (600 / ((float)xMax - (float)xMin)), 0, (float)Math.Abs(xMin) * (600 / ((float)xMax - (float)xMin)), CoordinatePlane.Height);



        }

        private float Convert_X_Point(float x)
        {
            int xMin = Convert.ToInt16(xMinRange.Value);
            int xMax = Convert.ToInt16(xMaxRange.Value);
            int yMin = Convert.ToInt16(yMinRange.Value);
            int yMax = Convert.ToInt16(yMaxRange.Value);

            float min = (float)xMin;
            float max = (float)xMax;

            if (xMin < 0)
            {
                return ((x + Math.Abs(min)) * (600 / (max - min)));
            }
            else
            {
                return (x * (600 / (max - min)));
            }

        }

        private float Convert_Y_Point(float y)
        {
            int xMin = Convert.ToInt16(xMinRange.Value);
            int xMax = Convert.ToInt16(xMaxRange.Value);
            int yMin = Convert.ToInt16(yMinRange.Value);
            int yMax = Convert.ToInt16(yMaxRange.Value);

            float min = (float)yMin;
            float max = (float)yMax;

            return (Math.Abs(y - max) * (600 / (max - min)));
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
            int xMin = Convert.ToInt16(xMinRange.Value);
            int xMax = Convert.ToInt16(xMaxRange.Value);
            int yMin = Convert.ToInt16(yMinRange.Value);
            int yMax = Convert.ToInt16(yMaxRange.Value);

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


            float m = float.Parse(linearM.Text);
            float b = float.Parse(linearB.Text);
            float y = (float)yMax;
            float x1;
            float x2;
            float y1;
            float y2;

            if (m != 0)
            {
                y1 = y;
                x1 = (y - b) / m;

                if (x1 < (float)xMin)
                {
                    x1 = (float)xMin;
                    y1 = (m * x1) + b;
                }

                x1 = Convert_X_Point(x1);
                y1 = Convert_Y_Point(y1);

                //Find the second point
                y = (float)yMin;

                y2 = y;
                x2 = (y - b) / m;

                if (x2 > (float)xMax)
                {
                    x2 = (float)xMax;
                    y2 = (m * x2) + b;
                }

                x2 = Convert_X_Point(x2);
                y2 = Convert_Y_Point(y2);
            }
            else
            {
                x1 = 0;
                y1 = b;
                x2 = CoordinatePlane.Width;
                y2 = b;

                y1 = Convert_Y_Point(y1);
                y2 = Convert_Y_Point(y2);
            }


            g.DrawLine(selectedPen, x1, y1, x2, y2);

        }

        private void quadGraph(object sender, EventArgs e)
        {
            //PointF[] points = new PointF[5];            

            Graphics g = CoordinatePlane.CreateGraphics();

            if ((string)quadColor.SelectedValue == "White")
            {
                selectedPen = new Pen(Color.White);
            }
            else if ((string)quadColor.SelectedValue == "Red")
            {
                selectedPen = new Pen(Color.Red);
            }
            else if ((string)quadColor.SelectedValue == "Green")
            {
                selectedPen = new Pen(Color.Green);
            }
            else if ((string)quadColor.SelectedValue == "Blue")
            {
                selectedPen = new Pen(Color.Blue);
            }

            List<PointF> pointList = new List<PointF>();
            float scale = 600 / 20;
            float a = Convert.ToSingle(quadA.Text) * scale;
            float b = Convert.ToSingle(quadB.Text) * scale;
            float c = Convert.ToSingle(quadC.Text) * scale;
            float xMinR = Convert.ToSingle(xMinRange.Value); //gets min x range and scales it to picture box
            float xMaxR = Convert.ToSingle(xMaxRange.Value); //gets max x range and scales it to picture box          

            //loops through the range of xmin to xmax
            for (float x = xMinR; x < xMaxR; x++)
            {
                //quad equation a,b,c,d are pulled from user entries
                float y = (a * (x * x) + (b * x + c));
                pointList.Add(new PointF((scale * 10) + x * scale, (scale * 10) - y));
            }
            PointF[] pointArray = pointList.ToArray();

            g.DrawCurve(selectedPen, pointArray);

            /*float x1;
            float y1;
            float x2;
            float y2;
            float xMid;
            float yMid;
            float x3;
            float y3;
            float x4;
            float y4;

            if (a != 0)
            {
                a *= -1;
                b *= -1;

                x1 = ((-1 * b) / (2 *  a)) - ((float)Math.Sqrt((b * b) - 4 * a * ((float)yMax - c)) / (2 * a));
                
                x4 = ((-1 * b) / (2 * a)) + ((float)Math.Sqrt((b * b) - 4 * a * ((float)yMax - c)) / (2 * a));

                a *= -1;
                b *= -1;

                xMid = (x1 + x4) / 2;
                yMid = a * (xMid * xMid) + b * xMid + c;
                x2 = (x1 + xMid) / 2;
                y2 = a * (x2 * x2) + b * x2 + c;
                x3 = (-1) * x2;
                y3 = y2 = a * (x3 * x3) + b * x3 + c;

                MessageBox.Show("");
                x1 = Convert_X_Point(x1);

                x2 = Convert_X_Point(x2);
                y2 = Convert_Y_Point(y2);

                xMid = Convert_X_Point(xMid);
                yMid = Convert_Y_Point(yMid);

                x3 = Convert_X_Point(x3);
                y3 = Convert_Y_Point(y3);

                x4 = Convert_X_Point(x4);

                points[0] = new PointF(x1, (float)yMax);
                points[1] = new PointF(x2, y2);
                points[2] = new PointF(xMid, yMid);
                points[3] = new PointF(x3, y3);
                points[4] = new PointF(x4, (float)yMax);
            }


            g.DrawCurve(whitePen, points);*/
        }

        private void cubicGraph(object sender, EventArgs e)
        {
            Graphics g = CoordinatePlane.CreateGraphics();

            if ((string)cubicColor.SelectedValue == "White")
            {
                selectedPen = new Pen(Color.White);
            }
            else if ((string)cubicColor.SelectedValue == "Red")
            {
                selectedPen = new Pen(Color.Red);
            }
            else if ((string)cubicColor.SelectedValue == "Green")
            {
                selectedPen = new Pen(Color.Green);
            }
            else if ((string)cubicColor.SelectedValue == "Blue")
            {
                selectedPen = new Pen(Color.Blue);
            }

            List<PointF> pointList = new List<PointF>();
            float scale = 600 / 20;
            float a = Convert.ToSingle(cubicA.Text) * scale;
            float b = Convert.ToSingle(cubicB.Text) * scale;
            float c = Convert.ToSingle(cubicC.Text) * scale;
            float d = Convert.ToSingle(cubicD.Text) * scale;
            float xMinR = Convert.ToSingle(xMinRange.Value); //gets min x range and scales it to picture box
            float xMaxR = Convert.ToSingle(xMaxRange.Value); //gets max x range and scales it to picture box          

            //loops through the range of xmin to xmax
            for (float x = xMinR; x < xMaxR; x++)
            {

                //cubic equation a,b,c,d are pulled from user entries
                float y = ((a * (x * x * x) + (b * (x * x) + (c * x) + d)));
                pointList.Add(new PointF((scale * 10) + x * scale, (scale * 10) - y));
            }
            PointF[] pointArray = pointList.ToArray();

            g.DrawCurve(selectedPen, pointArray);

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
            float h = Convert.ToSingle(circleH.Text) * scale;
            float k = Convert.ToSingle(circleK.Text) * scale;
            double tempR = Convert.ToSingle(circleR.Text);
            float r = (float)Math.Sqrt(tempR) * scale;

            g.DrawEllipse(selectedPen, h + (10 * scale) - r, (scale * 10) - k - r, r * 2, r * 2);

        }

        private void clearGraph(object sender, EventArgs e)
        {
            int xMin = Convert.ToInt16(xMinRange.Value);
            int xMax = Convert.ToInt16(xMaxRange.Value);
            int yMin = Convert.ToInt16(yMinRange.Value);
            int yMax = Convert.ToInt16(yMaxRange.Value);

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

        private void Coordinate_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;

            MessageBox.Show("X: " + coordinates.X + " Y: " + coordinates.Y);

        }
    }
}
