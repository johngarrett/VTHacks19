using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Media;
using System.Windows.Forms;
using System.Diagnostics;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace Soundboard
{
    public partial class Form1 : Form
    {Image knobImg = null;
        string pythonScript = "C:/Users/Cade/Desktop/VTHack/VTHacks19/Aruduino/file.py";
        string python = "C:/Python3/python.exe";

        private ProcessStartInfo myProcessStartInfo;
        myProcessStartInfo = new ProcessStartInfo("C:/Python3/python.exe");

        
        public Form1()
        {
            InitializeComponent();

            try {
                knobImg = Image.FromFile("C:/Users/Cade/Desktop/VTHack/VTHacks19/Soundboard/Assets/knob1.png");
                Console.WriteLine("Opening Port?");
                Port.Open();
            }
            catch (Exception exc) {
                MessageBox.Show("No Device connected.\n Verify COM number.");
            }

            Port.DataReceived += Port_DataReceived;
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

        private Bitmap RotateKnob(Bitmap bmp, float angle)
        {
            Bitmap rotatedImage = new Bitmap(bmp.Width, bmp.Height);
            using (Graphics g = Graphics.FromImage(rotatedImage))
            {
                // Set the rotation point to the center in the matrix
                g.TranslateTransform(bmp.Width / 2, bmp.Height / 2);
                // Rotate
                g.RotateTransform(angle);
                // Restore rotation point in the matrix
                g.TranslateTransform(-bmp.Width / 2, -bmp.Height / 2);
                // Draw the image on the bitmap
                g.DrawImage(bmp, new Point(0, 0));
            }

            return rotatedImage;
        }




        private void updateKnob(PictureBox pB, float rotation) {
            pB.Image = RotateKnob(new Bitmap(knobImg), rotation);
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
            updateKnob(pictureBox1, (float)(Math.PI));
        }


       

        private void timer1_Tick(object sender, EventArgs e)
        {
            string line = Port.ReadLine();

            Console.WriteLine(line);

            if (line.Contains("BTN: 1"))
            {
                playSimpleSound("Funk.wav");
            }
            if (line.Contains("BTN: 2"))
            {
                playSimpleSound("Pop.wav");
            }
            if (line.Contains("BTN: 3"))
            {
                playSimpleSound("Glass.wav");
            }
        }
    }
}
