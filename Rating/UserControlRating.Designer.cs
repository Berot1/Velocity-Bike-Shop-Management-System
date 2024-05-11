namespace Velocity_Bike_Shop_Managemennt_System.Rating
{
    partial class UserControlRating
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlRating));
            pbxStar1 = new PictureBox();
            pbxStar2 = new PictureBox();
            pbxStar3 = new PictureBox();
            pbxStar4 = new PictureBox();
            pbxStar5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbxStar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxStar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxStar3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxStar4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxStar5).BeginInit();
            SuspendLayout();
            // 
            // pbxStar1
            // 
            pbxStar1.Image = (Image)resources.GetObject("pbxStar1.Image");
            pbxStar1.Location = new Point(3, 5);
            pbxStar1.Name = "pbxStar1";
            pbxStar1.Size = new Size(24, 25);
            pbxStar1.SizeMode = PictureBoxSizeMode.Zoom;
            pbxStar1.TabIndex = 0;
            pbxStar1.TabStop = false;
            pbxStar1.Click += pbxStar1_Click;
            // 
            // pbxStar2
            // 
            pbxStar2.Image = (Image)resources.GetObject("pbxStar2.Image");
            pbxStar2.Location = new Point(33, 5);
            pbxStar2.Name = "pbxStar2";
            pbxStar2.Size = new Size(24, 25);
            pbxStar2.SizeMode = PictureBoxSizeMode.Zoom;
            pbxStar2.TabIndex = 1;
            pbxStar2.TabStop = false;
            pbxStar2.Click += pbxStar2_Click;
            // 
            // pbxStar3
            // 
            pbxStar3.Image = (Image)resources.GetObject("pbxStar3.Image");
            pbxStar3.Location = new Point(63, 5);
            pbxStar3.Name = "pbxStar3";
            pbxStar3.Size = new Size(24, 25);
            pbxStar3.SizeMode = PictureBoxSizeMode.Zoom;
            pbxStar3.TabIndex = 2;
            pbxStar3.TabStop = false;
            pbxStar3.Click += pbxStar3_Click;
            // 
            // pbxStar4
            // 
            pbxStar4.Image = (Image)resources.GetObject("pbxStar4.Image");
            pbxStar4.Location = new Point(93, 5);
            pbxStar4.Name = "pbxStar4";
            pbxStar4.Size = new Size(24, 25);
            pbxStar4.SizeMode = PictureBoxSizeMode.Zoom;
            pbxStar4.TabIndex = 3;
            pbxStar4.TabStop = false;
            pbxStar4.Click += pbxStar4_Click;
            // 
            // pbxStar5
            // 
            pbxStar5.Image = Properties.Resources.Empty_Star;
            pbxStar5.Location = new Point(123, 5);
            pbxStar5.Name = "pbxStar5";
            pbxStar5.Size = new Size(24, 25);
            pbxStar5.SizeMode = PictureBoxSizeMode.Zoom;
            pbxStar5.TabIndex = 4;
            pbxStar5.TabStop = false;
            pbxStar5.Click += pbxStar5_Click;
            // 
            // UserControlRating
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pbxStar5);
            Controls.Add(pbxStar4);
            Controls.Add(pbxStar3);
            Controls.Add(pbxStar2);
            Controls.Add(pbxStar1);
            Name = "UserControlRating";
            Size = new Size(150, 35);
            ((System.ComponentModel.ISupportInitialize)pbxStar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxStar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxStar3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxStar4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxStar5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbxStar1;
        private PictureBox pbxStar2;
        private PictureBox pbxStar3;
        private PictureBox pbxStar4;
        private PictureBox pbxStar5;
    }
}
