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
            this.rightKnob = new System.Windows.Forms.Button();
            this.leftKnob = new System.Windows.Forms.Button();
            this.Port = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // middleButton
            // 
            this.middleButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("middleButton.BackgroundImage")));
            this.middleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.middleButton.Location = new System.Drawing.Point(573, 104);
            this.middleButton.Name = "middleButton";
            this.middleButton.Size = new System.Drawing.Size(239, 198);
            this.middleButton.TabIndex = 0;
            this.middleButton.UseVisualStyleBackColor = true;
            this.middleButton.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // rightButton
            // 
            this.rightButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rightButton.BackgroundImage")));
            this.rightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rightButton.Location = new System.Drawing.Point(328, 111);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(239, 184);
            this.rightButton.TabIndex = 1;
            this.rightButton.UseVisualStyleBackColor = true;
            this.rightButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // leftButton
            // 
            this.leftButton.BackColor = System.Drawing.Color.Transparent;
            this.leftButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("leftButton.BackgroundImage")));
            this.leftButton.FlatAppearance.BorderSize = 0;
            this.leftButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leftButton.Location = new System.Drawing.Point(818, 98);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(239, 210);
            this.leftButton.TabIndex = 3;
            this.leftButton.UseVisualStyleBackColor = false;
            this.leftButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // rightKnob
            // 
            this.rightKnob.BackColor = System.Drawing.Color.Transparent;
            this.rightKnob.BackgroundImage = global::Soundboard.Properties.Resources.knob11;
            this.rightKnob.FlatAppearance.BorderSize = 0;
            this.rightKnob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rightKnob.ForeColor = System.Drawing.Color.Transparent;
            this.rightKnob.Location = new System.Drawing.Point(153, 98);
            this.rightKnob.Name = "rightKnob";
            this.rightKnob.Size = new System.Drawing.Size(116, 114);
            this.rightKnob.TabIndex = 5;
            this.rightKnob.UseVisualStyleBackColor = false;
            // 
            // leftKnob
            // 
            this.leftKnob.BackColor = System.Drawing.Color.Transparent;
            this.leftKnob.BackgroundImage = global::Soundboard.Properties.Resources.knob12;
            this.leftKnob.FlatAppearance.BorderSize = 0;
            this.leftKnob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leftKnob.Location = new System.Drawing.Point(31, 98);
            this.leftKnob.Name = "leftKnob";
            this.leftKnob.Size = new System.Drawing.Size(116, 114);
            this.leftKnob.TabIndex = 6;
            this.leftKnob.UseVisualStyleBackColor = false;
            // 
            // Port
            // 
            this.Port.PortName = "COM3";
            this.Port.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.Port_DataReceived);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Soundboard.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1132, 466);
            this.Controls.Add(this.leftKnob);
            this.Controls.Add(this.rightKnob);
            this.Controls.Add(this.leftButton);
            this.Controls.Add(this.rightButton);
            this.Controls.Add(this.middleButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button middleButton;
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.Button rightKnob;
        private System.Windows.Forms.Button leftKnob;
        public System.IO.Ports.SerialPort Port;
    }
}

