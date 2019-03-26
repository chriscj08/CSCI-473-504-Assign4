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
            ((System.ComponentModel.ISupportInitialize)(this.CoordinatePlane)).BeginInit();
            this.SuspendLayout();
            // 
            // CoordinatePlane
            // 
            this.CoordinatePlane.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CoordinatePlane.BackColor = System.Drawing.Color.Black;
            this.CoordinatePlane.Location = new System.Drawing.Point(12, 12);
            this.CoordinatePlane.Name = "CoordinatePlane";
            this.CoordinatePlane.Size = new System.Drawing.Size(500, 500);
            this.CoordinatePlane.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.CoordinatePlane.TabIndex = 0;
            this.CoordinatePlane.TabStop = false;
            this.CoordinatePlane.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawAxes);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 570);
            this.Controls.Add(this.CoordinatePlane);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.CoordinatePlane)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox CoordinatePlane;
    }
}

