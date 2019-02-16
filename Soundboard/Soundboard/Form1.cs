using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Media;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace Soundboard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            try {
                Port.Open();
            }
            catch (Exception exc) { 
                MessageBox.Show("No Device connected.\n Verify COM number.");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Click on the link below to continue learning how to build a desktop app using WinForms!
            System.Diagnostics.Process.Start("http://aka.ms/dotnet-get-started-desktop");

        }

        private void playSimpleSound(String filename)
        {
            SoundPlayer simpleSound = new SoundPlayer("C:/Users/Cade/Desktop/VTHack/VTHacks19/Soundboard/Assets/Good/" + filename);
            simpleSound.Play();
        }

        public static Image RotateImage(Image img, float rotationAngle)
        {
            //create an empty Bitmap image
            Bitmap bmp = new Bitmap(img.Width, img.Height);

            //turn the Bitmap into a Graphics object
            Graphics gfx = Graphics.FromImage(bmp);

            //now we set the rotation point to the center of our image
            gfx.TranslateTransform((float)bmp.Width / 2, (float)bmp.Height / 2);

            //now rotate the image
            gfx.RotateTransform(rotationAngle);

            gfx.TranslateTransform(-(float)bmp.Width / 2, -(float)bmp.Height / 2);

            //set the InterpolationMode to HighQualityBicubic so to ensure a high
            //quality image once it is transformed to the specified size
            gfx.InterpolationMode = InterpolationMode.HighQualityBicubic;

            //now draw our new image onto the graphics object
            gfx.DrawImage(img, new Point(0, 0));

            //dispose of our Graphics object
            gfx.Dispose();

            //return the image
            return bmp;
        }

        private void updateImage(PictureBox pB, float rotation) {
            pB.Image = RotateImage(pB.Image, rotation);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            playSimpleSound("Pop.wav");
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            playSimpleSound("Glass.wav");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Port_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            MessageBox.Show(Port.ReadLine());
        }

        private void leftKnob_Click(object sender, EventArgs e)
        {

        }

        private void middleButton_Click(object sender, EventArgs e)
        {
            playSimpleSound("Funk.wav");
            updateImage(pictureBox1, (float)(Math.PI / 8.0));
        }
    }
}
