namespace ImageProcessing
{
    partial class Form1
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnLoad = new Button();
            btnSave = new Button();
            openFileDialog1 = new OpenFileDialog();
            btnCopy = new Button();
            btnGreyscale = new Button();
            btnInvert = new Button();
            btnHistogram = new Button();
            saveFileDialog1 = new SaveFileDialog();
            btnSepia = new Button();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            btnLoadSub = new Button();
            btnLoadBg = new Button();
            btnSubtract = new Button();
            openFileDialog2 = new OpenFileDialog();
            openFileDialog3 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(31, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(348, 322);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(451, 25);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(348, 322);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(826, 101);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(107, 35);
            btnLoad.TabIndex = 3;
            btnLoad.Text = "Load Image";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(826, 142);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(107, 35);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save Image";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // btnCopy
            // 
            btnCopy.Location = new Point(826, 183);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(107, 35);
            btnCopy.TabIndex = 5;
            btnCopy.Text = "Basic Copy";
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += btnCopy_Click;
            // 
            // btnGreyscale
            // 
            btnGreyscale.Location = new Point(826, 224);
            btnGreyscale.Name = "btnGreyscale";
            btnGreyscale.Size = new Size(107, 35);
            btnGreyscale.TabIndex = 6;
            btnGreyscale.Text = "Greyscale";
            btnGreyscale.UseVisualStyleBackColor = true;
            btnGreyscale.Click += btnGreyscale_Click;
            // 
            // btnInvert
            // 
            btnInvert.Location = new Point(955, 101);
            btnInvert.Name = "btnInvert";
            btnInvert.Size = new Size(150, 35);
            btnInvert.TabIndex = 7;
            btnInvert.Text = "Color Inversion";
            btnInvert.UseVisualStyleBackColor = true;
            btnInvert.Click += btnInvert_Click;
            // 
            // btnHistogram
            // 
            btnHistogram.Location = new Point(955, 142);
            btnHistogram.Name = "btnHistogram";
            btnHistogram.Size = new Size(150, 35);
            btnHistogram.TabIndex = 8;
            btnHistogram.Text = "Histogram";
            btnHistogram.UseVisualStyleBackColor = true;
            btnHistogram.Click += btnHistogram_Click;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.FileOk += saveFileDialog1_FileOk;
            // 
            // btnSepia
            // 
            btnSepia.Location = new Point(955, 183);
            btnSepia.Name = "btnSepia";
            btnSepia.Size = new Size(107, 35);
            btnSepia.TabIndex = 9;
            btnSepia.Text = "Sepia";
            btnSepia.UseVisualStyleBackColor = true;
            btnSepia.Click += btnSepia_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(31, 426);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(414, 375);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(494, 426);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(414, 375);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Location = new Point(968, 426);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(414, 375);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 12;
            pictureBox5.TabStop = false;
            // 
            // btnLoadSub
            // 
            btnLoadSub.Location = new Point(164, 821);
            btnLoadSub.Name = "btnLoadSub";
            btnLoadSub.Size = new Size(136, 49);
            btnLoadSub.TabIndex = 14;
            btnLoadSub.Text = "Load Image";
            btnLoadSub.UseVisualStyleBackColor = true;
            btnLoadSub.Click += btnLoadSub_Click;
            // 
            // btnLoadBg
            // 
            btnLoadBg.Location = new Point(638, 821);
            btnLoadBg.Name = "btnLoadBg";
            btnLoadBg.Size = new Size(136, 49);
            btnLoadBg.TabIndex = 15;
            btnLoadBg.Text = "Load Background";
            btnLoadBg.UseVisualStyleBackColor = true;
            btnLoadBg.Click += btnLoadBg_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.Location = new Point(1123, 821);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(136, 49);
            btnSubtract.TabIndex = 16;
            btnSubtract.Text = "Subtract";
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += btnSubtract_Click;
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog2";
            openFileDialog2.FileOk += openFileDialog2_FileOk;
            // 
            // openFileDialog3
            // 
            openFileDialog3.FileName = "openFileDialog3";
            openFileDialog3.FileOk += openFileDialog3_FileOk;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1442, 967);
            Controls.Add(btnSubtract);
            Controls.Add(btnLoadBg);
            Controls.Add(btnLoadSub);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(btnSepia);
            Controls.Add(btnHistogram);
            Controls.Add(btnInvert);
            Controls.Add(btnGreyscale);
            Controls.Add(btnCopy);
            Controls.Add(btnSave);
            Controls.Add(btnLoad);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnLoad;
        private Button btnSave;
        private OpenFileDialog openFileDialog1;
        private Button btnCopy;
        private Button btnGreyscale;
        private Button btnInvert;
        private Button btnHistogram;
        private SaveFileDialog saveFileDialog1;
        private Button btnSepia;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Button btnLoadSub;
        private Button btnLoadBg;
        private Button btnSubtract;
        private OpenFileDialog openFileDialog2;
        private OpenFileDialog openFileDialog3;
    }
}