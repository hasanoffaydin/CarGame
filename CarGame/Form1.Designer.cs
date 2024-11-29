namespace CarGame
{
    partial class CarRace
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            pictureBox3 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            buttonSelectImages = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.Location = new Point(579, 25);
            label1.Name = "label1";
            label1.Size = new Size(323, 41);
            label1.TabIndex = 0;
            label1.Text = "Masin Yarislari Oyunu";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.OIP;
            pictureBox1.Location = new Point(60, 105);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(266, 208);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.download;
            pictureBox2.Location = new Point(60, 387);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(266, 208);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(534, 677);
            button1.Name = "button1";
            button1.Size = new Size(194, 76);
            button1.TabIndex = 3;
            button1.Text = "Start Race";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.finish;
            pictureBox3.Location = new Point(1082, 228);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(239, 256);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonSelectImages
            // 
            buttonSelectImages.BackColor = Color.Red;
            buttonSelectImages.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            buttonSelectImages.ForeColor = Color.White;
            buttonSelectImages.Location = new Point(818, 677);
            buttonSelectImages.Name = "buttonSelectImages";
            buttonSelectImages.Size = new Size(194, 76);
            buttonSelectImages.TabIndex = 5;
            buttonSelectImages.Text = "Choose Cars";
            buttonSelectImages.UseVisualStyleBackColor = false;
            buttonSelectImages.Click += buttonSelectImages_Click_1;
            // 
            // CarRace
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1366, 765);
            Controls.Add(buttonSelectImages);
            Controls.Add(pictureBox3);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "CarRace";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CarRace";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button1;
        private PictureBox pictureBox3;
        private OpenFileDialog openFileDialog1;
        private Button buttonSelectImages;
    }
}
