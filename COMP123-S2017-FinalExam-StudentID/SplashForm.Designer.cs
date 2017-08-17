namespace COMP123_S2017_FinalExam_StudentID
{
    partial class SplashForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashForm));
            this.splashImage = new System.Windows.Forms.PictureBox();
            this.splashProgressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.splashImage)).BeginInit();
            this.SuspendLayout();
            // 
            // splashImage
            // 
            this.splashImage.Image = ((System.Drawing.Image)(resources.GetObject("splashImage.Image")));
            this.splashImage.Location = new System.Drawing.Point(0, -1);
            this.splashImage.Name = "splashImage";
            this.splashImage.Size = new System.Drawing.Size(584, 420);
            this.splashImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.splashImage.TabIndex = 0;
            this.splashImage.TabStop = false;
            // 
            // splashProgressBar
            // 
            this.splashProgressBar.Location = new System.Drawing.Point(0, 425);
            this.splashProgressBar.MarqueeAnimationSpeed = 50;
            this.splashProgressBar.Name = "splashProgressBar";
            this.splashProgressBar.Size = new System.Drawing.Size(584, 36);
            this.splashProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.splashProgressBar.TabIndex = 1;
            // 
            // SplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(584, 462);
            this.ControlBox = false;
            this.Controls.Add(this.splashProgressBar);
            this.Controls.Add(this.splashImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SplashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash Form";
            ((System.ComponentModel.ISupportInitialize)(this.splashImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox splashImage;
        private System.Windows.Forms.ProgressBar splashProgressBar;
    }
}