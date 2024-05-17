namespace Zodiac
{
    partial class ZodiacManager
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lblWelcome = new Label();
            picImage = new PictureBox();
            btnShowImage = new Button();
            pnlImage = new Panel();
            btnCheckZodiac = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)picImage).BeginInit();
            pnlImage.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1, -1);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.Yellow;
            lblWelcome.Location = new Point(0, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(535, 81);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Zodiac Calculator";
            lblWelcome.Click += label2_Click;
            // 
            // picImage
            // 
            picImage.BackColor = Color.Lime;
            picImage.BackgroundImageLayout = ImageLayout.None;
            picImage.Location = new Point(15, 19);
            picImage.Name = "picImage";
            picImage.Size = new Size(276, 342);
            picImage.SizeMode = PictureBoxSizeMode.AutoSize;
            picImage.TabIndex = 2;
            picImage.TabStop = false;
            picImage.Click += pictureBox1_Click;
            // 
            // btnShowImage
            // 
            btnShowImage.BackColor = Color.Red;
            btnShowImage.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnShowImage.ForeColor = Color.Yellow;
            btnShowImage.Location = new Point(12, 98);
            btnShowImage.Name = "btnShowImage";
            btnShowImage.Size = new Size(162, 43);
            btnShowImage.TabIndex = 3;
            btnShowImage.Text = "Show Image";
            btnShowImage.UseVisualStyleBackColor = false;
            btnShowImage.Click += btnShowImage_Click;
            // 
            // pnlImage
            // 
            pnlImage.AutoScroll = true;
            pnlImage.BackColor = Color.Fuchsia;
            pnlImage.Controls.Add(picImage);
            pnlImage.Location = new Point(547, 98);
            pnlImage.Name = "pnlImage";
            pnlImage.Size = new Size(306, 376);
            pnlImage.TabIndex = 4;
            // 
            // btnCheckZodiac
            // 
            btnCheckZodiac.BackColor = Color.Red;
            btnCheckZodiac.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCheckZodiac.ForeColor = Color.Yellow;
            btnCheckZodiac.Location = new Point(180, 98);
            btnCheckZodiac.Name = "btnCheckZodiac";
            btnCheckZodiac.Size = new Size(162, 43);
            btnCheckZodiac.TabIndex = 5;
            btnCheckZodiac.Text = "Check Zodiac";
            btnCheckZodiac.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.Yellow;
            btnExit.Location = new Point(348, 98);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(162, 43);
            btnExit.TabIndex = 6;
            btnExit.Text = "Quit";
            btnExit.UseVisualStyleBackColor = false;
            // 
            // ZodiacManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(920, 504);
            Controls.Add(btnExit);
            Controls.Add(btnCheckZodiac);
            Controls.Add(pnlImage);
            Controls.Add(btnShowImage);
            Controls.Add(lblWelcome);
            Controls.Add(label1);
            Name = "ZodiacManager";
            Text = "Welcomea to Zodiac Calculator";
            Load += ZodiacManager_Load;
            ((System.ComponentModel.ISupportInitialize)picImage).EndInit();
            pnlImage.ResumeLayout(false);
            pnlImage.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblWelcome;
        private PictureBox picImage;
        private Button btnShowImage;
        private Panel pnlImage;
        private Button btnCheckZodiac;
        private Button btnExit;
    }
}
