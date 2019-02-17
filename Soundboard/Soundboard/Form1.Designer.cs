namespace Soundboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.middleButton = new System.Windows.Forms.Button();
            this.rightButton = new System.Windows.Forms.Button();
            this.leftButton = new System.Windows.Forms.Button();
            this.Port = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // middleButton
            // 
            this.middleButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("middleButton.BackgroundImage")));
            this.middleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.middleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.middleButton.Location = new System.Drawing.Point(573, 104);
            this.middleButton.Name = "middleButton";
            this.middleButton.Size = new System.Drawing.Size(239, 198);
            this.middleButton.TabIndex = 0;
            this.middleButton.UseVisualStyleBackColor = true;
            this.middleButton.Click += new System.EventHandler(this.middleButton_Click);
            // 
            // rightButton
            // 
            this.rightButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rightButton.BackgroundImage")));
            this.rightButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rightButton.Location = new System.Drawing.Point(307, 111);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(260, 184);
            this.rightButton.TabIndex = 1;
            this.rightButton.UseVisualStyleBackColor = true;
            this.rightButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // leftButton
            // 
            this.leftButton.BackColor = System.Drawing.Color.Transparent;
            this.leftButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("leftButton.BackgroundImage")));
            this.leftButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.leftButton.FlatAppearance.BorderSize = 0;
            this.leftButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leftButton.Location = new System.Drawing.Point(818, 98);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(239, 210);
            this.leftButton.TabIndex = 3;
            this.leftButton.UseVisualStyleBackColor = false;
            this.leftButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // Port
            // 
            this.Port.PortName = "COM4";
            this.Port.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.Port_DataReceived);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Soundboard.Properties.Resources.knob12;
            this.pictureBox1.Location = new System.Drawing.Point(12, 146);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Soundboard.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1132, 466);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.leftButton);
            this.Controls.Add(this.rightButton);
            this.Controls.Add(this.middleButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button middleButton;
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.Button leftButton;
        public System.IO.Ports.SerialPort Port;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}

