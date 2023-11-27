using System.Diagnostics;

namespace ImageProcessing
{
    public partial class Form1 : Form
    {
        Bitmap loadImage, resultImage;
        Bitmap imageA, imageB, colorgreen;
        public Form1()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            loadImage = new Bitmap(openFileDialog1.FileName);
            pictureBox1.Image = loadImage;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            loadImage = new Bitmap(openFileDialog1.FileName);
            Color pixel;

            resultImage = new Bitmap(loadImage.Width, loadImage.Height);
            for (int i = 0; i < loadImage.Width; i++)
            {
                for (int j = 0; j < loadImage.Height; j++)
                {
                    pixel = loadImage.GetPixel(i, j);
                    resultImage.SetPixel(i, j, pixel);
                }
            }
            pictureBox2.Image = resultImage;

        }

        private void btnGreyscale_Click(object sender, EventArgs e)
        {
            Color pixel;
            int gray;

            resultImage = new Bitmap(loadImage.Width, loadImage.Height);
            for (int i = 0; i < loadImage.Width; i++)
            {
                for (int j = 0; j < loadImage.Height; j++)
                {
                    pixel = loadImage.GetPixel(i, j);
                    gray = (pixel.R + pixel.G + pixel.B) / 3;
                    resultImage.SetPixel(i, j, Color.FromArgb(gray, gray, gray));
                }
            }
            pictureBox2.Image = resultImage;
        }

        private void btnInvert_Click(object sender, EventArgs e)
        {
            Color pixel;

            resultImage = new Bitmap(loadImage.Width, loadImage.Height);
            for (int i = 0; i < loadImage.Width; i++)
            {
                for (int j = 0; j < loadImage.Height; j++)
                {
                    pixel = loadImage.GetPixel(i, j);
                    resultImage.SetPixel(i, j, Color.FromArgb(255 - pixel.R, 255 - pixel.G, 255 - pixel.B));
                }
            }
            pictureBox2.Image = resultImage;
        }

        private void btnHistogram_Click(object sender, EventArgs e)
        {
            Color pixel, sample;
            int gray;

            resultImage = new Bitmap(loadImage.Width, loadImage.Height);
            for (int i = 0; i < loadImage.Width; i++)
            {
                for (int j = 0; j < loadImage.Height; j++)
                {
                    pixel = loadImage.GetPixel(i, j);
                    gray = (pixel.R + pixel.G + pixel.B) / 3;
                    resultImage.SetPixel(i, j, Color.FromArgb(gray, gray, gray));
                }
            }
            int[] histdata = new int[256];
            for (int i = 0; i < loadImage.Width; i++)
            {
                for (int j = 0; j < loadImage.Height; j++)
                {
                    sample = resultImage.GetPixel(i, j);
                    histdata[sample.R]++;
                }
            }

            Bitmap mydata = new Bitmap(256, 800);

            for (int i = 0; i < 256; i++)
            {
                for (int j = 0; j < 800; j++)
                {
                    mydata.SetPixel(i, j, Color.White);
                }
            }

            //plotting of histdata
            for (int i = 0; i < 256; i++)
            {
                for (int j = 0; j < Math.Min(histdata[i] / 5, 800); j++)
                {
                    mydata.SetPixel(i, 799 - j, Color.Black);
                }
            }
            pictureBox2.Image = mydata;
        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            resultImage.Save(saveFileDialog1.FileName);
        }

        private void btnSepia_Click(object sender, EventArgs e)
        {
            Color pixel;
            int gray, red, green, blue;

            resultImage = new Bitmap(loadImage.Width, loadImage.Height);
            for (int i = 0; i < loadImage.Width; i++)
            {
                for (int j = 0; j < loadImage.Height; j++)
                {
                    pixel = loadImage.GetPixel(i, j);
                    gray = (pixel.R + pixel.G + pixel.B) / 3;
                    red = Math.Min(255, (int)(gray * 0.393 + gray * 0.769 + gray * 0.189));
                    green = Math.Min(255, (int)(gray * 0.349 + gray * 0.686 + gray * 0.168));
                    blue = Math.Min(255, (int)(gray * 0.272 + gray * 0.534 + gray * 0.131));
                    resultImage.SetPixel(i, j, Color.FromArgb(red, green, blue));
                }
            }
            pictureBox2.Image = resultImage;
        }

        private void btnLoadSub_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
        }

        private void openFileDialog2_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            imageB = new Bitmap(openFileDialog2.FileName);
            pictureBox3.Image = imageB;
        }

        private void btnLoadBg_Click(object sender, EventArgs e)
        {
            openFileDialog3.ShowDialog();
        }

        private void openFileDialog3_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            imageA = new Bitmap(openFileDialog3.FileName);
            pictureBox4.Image = imageA;
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            Color mygreen = Color.FromArgb(0, 0, 255);
            int greygreen = (mygreen.R + mygreen.G + mygreen.B);
            int threshold = 5;

            resultImage = new Bitmap(imageA.Width, imageA.Height);

            for (int x = 0; x < imageB.Width; x++)
                for (int y = 0; y < imageB.Height; y++)
                {
                    Color pixel = imageB.GetPixel(x, y);
                    Color backpixel = imageA.GetPixel(x, y);
                    int grey = (pixel.R + pixel.G + pixel.B) / 3;
                    int chrKeyGrey = (mygreen.R + mygreen.G + mygreen.B) / 3;
                    int subtractvalue = Math.Abs(grey - chrKeyGrey);

                    if (subtractvalue > threshold)
                        resultImage.SetPixel(x, y, pixel);
                    else
                        resultImage.SetPixel(x, y, backpixel);
                }
            pictureBox5.Image = resultImage;
        }
    }
}