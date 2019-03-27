namespace Chris_Parker_Assign4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CoordinatePlane = new System.Windows.Forms.PictureBox();
            this.linearM = new System.Windows.Forms.TextBox();
            this.linearB = new System.Windows.Forms.TextBox();
            this.quadB = new System.Windows.Forms.TextBox();
            this.quadA = new System.Windows.Forms.TextBox();
            this.quadC = new System.Windows.Forms.TextBox();
            this.cubicA = new System.Windows.Forms.TextBox();
            this.cubicD = new System.Windows.Forms.TextBox();
            this.cubicC = new System.Windows.Forms.TextBox();
            this.cubicB = new System.Windows.Forms.TextBox();
            this.circleR = new System.Windows.Forms.TextBox();
            this.circleK = new System.Windows.Forms.TextBox();
            this.circleH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.displayBoxBottom = new System.Windows.Forms.RichTextBox();
            this.Header = new System.Windows.Forms.Label();
            this.textHeader = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.linearColor = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.quadColor = new System.Windows.Forms.ComboBox();
            this.button7 = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.cubicColor = new System.Windows.Forms.ComboBox();
            this.circleColor = new System.Windows.Forms.ComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rangeXMin = new System.Windows.Forms.TextBox();
            this.rangeYMax = new System.Windows.Forms.TextBox();
            this.rangeYMin = new System.Windows.Forms.TextBox();
            this.rangeXMax = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CoordinatePlane)).BeginInit();
            this.SuspendLayout();
            // 
            // CoordinatePlane
            // 
            this.CoordinatePlane.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CoordinatePlane.BackColor = System.Drawing.Color.Black;
            this.CoordinatePlane.Location = new System.Drawing.Point(495, 13);
            this.CoordinatePlane.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CoordinatePlane.Name = "CoordinatePlane";
            this.CoordinatePlane.Size = new System.Drawing.Size(744, 744);
            this.CoordinatePlane.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.CoordinatePlane.TabIndex = 0;
            this.CoordinatePlane.TabStop = false;
            this.CoordinatePlane.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawAxes);
            // 
            // linearM
            // 
            this.linearM.ForeColor = System.Drawing.SystemColors.WindowText;
            this.linearM.Location = new System.Drawing.Point(93, 148);
            this.linearM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.linearM.Name = "linearM";
            this.linearM.Size = new System.Drawing.Size(29, 22);
            this.linearM.TabIndex = 4;
            this.linearM.TextChanged += new System.EventHandler(this.linearMTxtChange);
            this.linearM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.linearMKeyPress);
            // 
            // linearB
            // 
            this.linearB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.linearB.Location = new System.Drawing.Point(168, 149);
            this.linearB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.linearB.Name = "linearB";
            this.linearB.Size = new System.Drawing.Size(32, 22);
            this.linearB.TabIndex = 5;
            // 
            // quadB
            // 
            this.quadB.Location = new System.Drawing.Point(176, 245);
            this.quadB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.quadB.Name = "quadB";
            this.quadB.Size = new System.Drawing.Size(32, 22);
            this.quadB.TabIndex = 7;
            // 
            // quadA
            // 
            this.quadA.Location = new System.Drawing.Point(91, 245);
            this.quadA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.quadA.Name = "quadA";
            this.quadA.Size = new System.Drawing.Size(32, 22);
            this.quadA.TabIndex = 6;
            // 
            // quadC
            // 
            this.quadC.Location = new System.Drawing.Point(249, 245);
            this.quadC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.quadC.Name = "quadC";
            this.quadC.Size = new System.Drawing.Size(32, 22);
            this.quadC.TabIndex = 8;
            // 
            // cubicA
            // 
            this.cubicA.Location = new System.Drawing.Point(84, 356);
            this.cubicA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cubicA.Name = "cubicA";
            this.cubicA.Size = new System.Drawing.Size(32, 22);
            this.cubicA.TabIndex = 9;
            // 
            // cubicD
            // 
            this.cubicD.Location = new System.Drawing.Point(339, 356);
            this.cubicD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cubicD.Name = "cubicD";
            this.cubicD.Size = new System.Drawing.Size(32, 22);
            this.cubicD.TabIndex = 12;
            // 
            // cubicC
            // 
            this.cubicC.Location = new System.Drawing.Point(267, 357);
            this.cubicC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cubicC.Name = "cubicC";
            this.cubicC.Size = new System.Drawing.Size(32, 22);
            this.cubicC.TabIndex = 11;
            // 
            // cubicB
            // 
            this.cubicB.Location = new System.Drawing.Point(173, 357);
            this.cubicB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cubicB.Name = "cubicB";
            this.cubicB.Size = new System.Drawing.Size(32, 22);
            this.cubicB.TabIndex = 10;
            // 
            // circleR
            // 
            this.circleR.Location = new System.Drawing.Point(301, 464);
            this.circleR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.circleR.Name = "circleR";
            this.circleR.Size = new System.Drawing.Size(32, 22);
            this.circleR.TabIndex = 15;
            // 
            // circleK
            // 
            this.circleK.Location = new System.Drawing.Point(224, 465);
            this.circleK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.circleK.Name = "circleK";
            this.circleK.Size = new System.Drawing.Size(32, 22);
            this.circleK.TabIndex = 14;
            // 
            // circleH
            // 
            this.circleH.Location = new System.Drawing.Point(115, 464);
            this.circleH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.circleH.Name = "circleH";
            this.circleH.Size = new System.Drawing.Size(32, 22);
            this.circleH.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 151);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Y =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 153);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "x +";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 129);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "m";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(107, 225);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "a";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(184, 129);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "b";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(355, 336);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "d";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(283, 337);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "c";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(187, 337);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 17);
            this.label9.TabIndex = 23;
            this.label9.Text = "b";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(100, 336);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "a";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(317, 444);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 17);
            this.label11.TabIndex = 27;
            this.label11.Text = "r";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(228, 444);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 17);
            this.label12.TabIndex = 26;
            this.label12.Text = "k";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(128, 444);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(16, 17);
            this.label13.TabIndex = 25;
            this.label13.Text = "h";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 336);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 17);
            this.label14.TabIndex = 31;
            this.label14.Text = "3. Cubic";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 225);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 17);
            this.label15.TabIndex = 30;
            this.label15.Text = "2. Quad";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 128);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 17);
            this.label16.TabIndex = 29;
            this.label16.Text = "1. Linear";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(16, 444);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 17);
            this.label17.TabIndex = 28;
            this.label17.Text = "4. Circle";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(20, 180);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 28);
            this.button2.TabIndex = 32;
            this.button2.Text = "Hint";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.LinEqHint);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(20, 279);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 28);
            this.button3.TabIndex = 33;
            this.button3.Text = "Hint";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.QuadEqHint);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(21, 384);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(71, 28);
            this.button4.TabIndex = 34;
            this.button4.Text = "Hint";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.CubEqHint);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(20, 512);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(71, 28);
            this.button5.TabIndex = 35;
            this.button5.Text = "Hint";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.CirEqHint);
            // 
            // displayBoxBottom
            // 
            this.displayBoxBottom.Location = new System.Drawing.Point(20, 643);
            this.displayBoxBottom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.displayBoxBottom.Name = "displayBoxBottom";
            this.displayBoxBottom.Size = new System.Drawing.Size(413, 112);
            this.displayBoxBottom.TabIndex = 36;
            this.displayBoxBottom.Text = "";
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.Location = new System.Drawing.Point(88, 15);
            this.Header.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(226, 29);
            this.Header.TabIndex = 37;
            this.Header.Text = "Graphing Calculator";
            // 
            // textHeader
            // 
            this.textHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textHeader.Location = new System.Drawing.Point(16, 48);
            this.textHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textHeader.Name = "textHeader";
            this.textHeader.Size = new System.Drawing.Size(417, 48);
            this.textHeader.TabIndex = 38;
            this.textHeader.Text = "Enter equations that wish to be graphed. A color is also required and can only be" +
    " used once.\n";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(389, 149);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 28);
            this.button1.TabIndex = 39;
            this.button1.Text = "Graph";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.linearGraph);
            // 
            // linearColor
            // 
            this.linearColor.FormattingEnabled = true;
            this.linearColor.Items.AddRange(new object[] {
            "White",
            "Red",
            "Green",
            "Blue"});
            this.linearColor.Location = new System.Drawing.Point(219, 182);
            this.linearColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.linearColor.Name = "linearColor";
            this.linearColor.Size = new System.Drawing.Size(115, 24);
            this.linearColor.TabIndex = 40;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(55, 254);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(29, 17);
            this.label18.TabIndex = 41;
            this.label18.Text = "Y =";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(48, 366);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(29, 17);
            this.label19.TabIndex = 42;
            this.label19.Text = "Y =";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(55, 473);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(58, 17);
            this.label20.TabIndex = 43;
            this.label20.Text = "Y = (( x-";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(125, 364);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(41, 17);
            this.label21.TabIndex = 44;
            this.label21.Text = "x^3 +";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(192, 225);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(16, 17);
            this.label22.TabIndex = 45;
            this.label22.Text = "b";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(213, 254);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(26, 17);
            this.label23.TabIndex = 46;
            this.label23.Text = "x +";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(265, 225);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(15, 17);
            this.label24.TabIndex = 47;
            this.label24.Text = "c";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(389, 245);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(68, 28);
            this.button6.TabIndex = 48;
            this.button6.Text = "Graph";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.quadGraph);
            // 
            // quadColor
            // 
            this.quadColor.FormattingEnabled = true;
            this.quadColor.Items.AddRange(new object[] {
            "White",
            "Red",
            "Green",
            "Blue"});
            this.quadColor.Location = new System.Drawing.Point(219, 282);
            this.quadColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.quadColor.Name = "quadColor";
            this.quadColor.Size = new System.Drawing.Size(115, 24);
            this.quadColor.TabIndex = 49;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(391, 352);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(68, 28);
            this.button7.TabIndex = 50;
            this.button7.Text = "Graph";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.cubicGraph);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(131, 254);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(41, 17);
            this.label25.TabIndex = 51;
            this.label25.Text = "x^2 +";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(215, 366);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(41, 17);
            this.label26.TabIndex = 52;
            this.label26.Text = "x^2 +";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(308, 366);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(26, 17);
            this.label27.TabIndex = 53;
            this.label27.Text = "x +";
            // 
            // cubicColor
            // 
            this.cubicColor.FormattingEnabled = true;
            this.cubicColor.Items.AddRange(new object[] {
            "White",
            "Red",
            "Green",
            "Blue"});
            this.cubicColor.Location = new System.Drawing.Point(220, 389);
            this.cubicColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cubicColor.Name = "cubicColor";
            this.cubicColor.Size = new System.Drawing.Size(115, 24);
            this.cubicColor.TabIndex = 54;
            // 
            // circleColor
            // 
            this.circleColor.FormattingEnabled = true;
            this.circleColor.Items.AddRange(new object[] {
            "White",
            "Red",
            "Green",
            "Blue"});
            this.circleColor.Location = new System.Drawing.Point(219, 514);
            this.circleColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.circleColor.Name = "circleColor";
            this.circleColor.Size = new System.Drawing.Size(115, 24);
            this.circleColor.TabIndex = 55;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(155, 473);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(61, 17);
            this.label28.TabIndex = 56;
            this.label28.Text = ")^2+( y -";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(256, 473);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(40, 17);
            this.label29.TabIndex = 57;
            this.label29.Text = ")^2 =";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(343, 473);
            this.label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(23, 17);
            this.label30.TabIndex = 58;
            this.label30.Text = "^2";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(389, 464);
            this.button8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(68, 28);
            this.button8.TabIndex = 59;
            this.button8.Text = "Graph";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.circleGraph);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(172, 186);
            this.label31.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(41, 17);
            this.label31.TabIndex = 60;
            this.label31.Text = "Color";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(172, 286);
            this.label32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(41, 17);
            this.label32.TabIndex = 61;
            this.label32.Text = "Color";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(173, 393);
            this.label33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(41, 17);
            this.label33.TabIndex = 62;
            this.label33.Text = "Color";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(172, 518);
            this.label34.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(41, 17);
            this.label34.TabIndex = 63;
            this.label34.Text = "Color";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(376, 574);
            this.button9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(81, 28);
            this.button9.TabIndex = 64;
            this.button9.Text = "Clear All";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.clearGraph);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 544);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 65;
            this.label1.Text = "Range";
            // 
            // rangeXMin
            // 
            this.rangeXMin.Location = new System.Drawing.Point(38, 594);
            this.rangeXMin.Name = "rangeXMin";
            this.rangeXMin.Size = new System.Drawing.Size(30, 22);
            this.rangeXMin.TabIndex = 66;
            // 
            // rangeYMax
            // 
            this.rangeYMax.Location = new System.Drawing.Point(231, 594);
            this.rangeYMax.Name = "rangeYMax";
            this.rangeYMax.Size = new System.Drawing.Size(30, 22);
            this.rangeYMax.TabIndex = 67;
            // 
            // rangeYMin
            // 
            this.rangeYMin.Location = new System.Drawing.Point(178, 594);
            this.rangeYMin.Name = "rangeYMin";
            this.rangeYMin.Size = new System.Drawing.Size(30, 22);
            this.rangeYMin.TabIndex = 68;
            // 
            // rangeXMax
            // 
            this.rangeXMax.Location = new System.Drawing.Point(86, 594);
            this.rangeXMax.Name = "rangeXMax";
            this.rangeXMax.Size = new System.Drawing.Size(30, 22);
            this.rangeXMax.TabIndex = 69;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(35, 574);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(89, 17);
            this.label35.TabIndex = 70;
            this.label35.Text = "x-min   x-max";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(175, 574);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(91, 17);
            this.label36.TabIndex = 71;
            this.label36.Text = "y-min   y-max";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 770);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.rangeXMax);
            this.Controls.Add(this.rangeYMin);
            this.Controls.Add(this.rangeYMax);
            this.Controls.Add(this.rangeXMin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.circleColor);
            this.Controls.Add(this.cubicColor);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.quadColor);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.linearColor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textHeader);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.displayBoxBottom);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.circleR);
            this.Controls.Add(this.circleK);
            this.Controls.Add(this.circleH);
            this.Controls.Add(this.cubicD);
            this.Controls.Add(this.cubicC);
            this.Controls.Add(this.cubicB);
            this.Controls.Add(this.cubicA);
            this.Controls.Add(this.quadC);
            this.Controls.Add(this.quadB);
            this.Controls.Add(this.quadA);
            this.Controls.Add(this.linearB);
            this.Controls.Add(this.linearM);
            this.Controls.Add(this.CoordinatePlane);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CoordinatePlane)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CoordinatePlane;
        private System.Windows.Forms.TextBox linearM;
        private System.Windows.Forms.TextBox linearB;
        private System.Windows.Forms.TextBox quadB;
        private System.Windows.Forms.TextBox quadA;
        private System.Windows.Forms.TextBox quadC;
        private System.Windows.Forms.TextBox cubicA;
        private System.Windows.Forms.TextBox cubicD;
        private System.Windows.Forms.TextBox cubicC;
        private System.Windows.Forms.TextBox cubicB;
        private System.Windows.Forms.TextBox circleR;
        private System.Windows.Forms.TextBox circleK;
        private System.Windows.Forms.TextBox circleH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.RichTextBox displayBoxBottom;
        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.RichTextBox textHeader;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox linearColor;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox quadColor;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ComboBox cubicColor;
        private System.Windows.Forms.ComboBox circleColor;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rangeXMin;
        private System.Windows.Forms.TextBox rangeYMax;
        private System.Windows.Forms.TextBox rangeYMin;
        private System.Windows.Forms.TextBox rangeXMax;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
    }
}

