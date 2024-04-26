namespace Robotics_Lecture_Arduino_GUI_2_Forms
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.greenLEDCheckbox = new System.Windows.Forms.CheckBox();
            this.yellowLEDCheckbox = new System.Windows.Forms.CheckBox();
            this.redLEDCheckbox = new System.Windows.Forms.CheckBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.greenButton = new System.Windows.Forms.Button();
            this.greenTrackBar = new System.Windows.Forms.TrackBar();
            this.yellowButton = new System.Windows.Forms.Button();
            this.yellowTrackBar = new System.Windows.Forms.TrackBar();
            this.redButton = new System.Windows.Forms.Button();
            this.redTrackBar = new System.Windows.Forms.TrackBar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.servoRichTextBox = new System.Windows.Forms.RichTextBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.setServoAngleButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.greenTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redTrackBar)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.greenLEDCheckbox);
            this.groupBox1.Controls.Add(this.yellowLEDCheckbox);
            this.groupBox1.Controls.Add(this.redLEDCheckbox);
            this.groupBox1.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(44, 37);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(209, 142);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LED Selector";
            // 
            // greenLEDCheckbox
            // 
            this.greenLEDCheckbox.AutoSize = true;
            this.greenLEDCheckbox.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greenLEDCheckbox.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.greenLEDCheckbox.Location = new System.Drawing.Point(23, 93);
            this.greenLEDCheckbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.greenLEDCheckbox.Name = "greenLEDCheckbox";
            this.greenLEDCheckbox.Size = new System.Drawing.Size(154, 27);
            this.greenLEDCheckbox.TabIndex = 2;
            this.greenLEDCheckbox.Text = "Turn Green LED";
            this.greenLEDCheckbox.UseVisualStyleBackColor = true;
            this.greenLEDCheckbox.CheckedChanged += new System.EventHandler(this.greenCheckBox_CheckedChanged);
            // 
            // yellowLEDCheckbox
            // 
            this.yellowLEDCheckbox.AutoSize = true;
            this.yellowLEDCheckbox.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yellowLEDCheckbox.ForeColor = System.Drawing.Color.Goldenrod;
            this.yellowLEDCheckbox.Location = new System.Drawing.Point(23, 62);
            this.yellowLEDCheckbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.yellowLEDCheckbox.Name = "yellowLEDCheckbox";
            this.yellowLEDCheckbox.Size = new System.Drawing.Size(158, 27);
            this.yellowLEDCheckbox.TabIndex = 1;
            this.yellowLEDCheckbox.Text = "Turn Yellow LED";
            this.yellowLEDCheckbox.UseVisualStyleBackColor = true;
            this.yellowLEDCheckbox.CheckedChanged += new System.EventHandler(this.yellowLEDCheckbox_CheckedChanged);
            // 
            // redLEDCheckbox
            // 
            this.redLEDCheckbox.AutoSize = true;
            this.redLEDCheckbox.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redLEDCheckbox.ForeColor = System.Drawing.Color.OrangeRed;
            this.redLEDCheckbox.Location = new System.Drawing.Point(23, 32);
            this.redLEDCheckbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.redLEDCheckbox.Name = "redLEDCheckbox";
            this.redLEDCheckbox.Size = new System.Drawing.Size(137, 27);
            this.redLEDCheckbox.TabIndex = 0;
            this.redLEDCheckbox.Text = "Turn Red LED";
            this.redLEDCheckbox.UseVisualStyleBackColor = true;
            this.redLEDCheckbox.CheckedChanged += new System.EventHandler(this.redLEDCheckbox_CheckedChanged);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM6";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.greenButton);
            this.groupBox2.Controls.Add(this.greenTrackBar);
            this.groupBox2.Controls.Add(this.yellowButton);
            this.groupBox2.Controls.Add(this.yellowTrackBar);
            this.groupBox2.Controls.Add(this.redButton);
            this.groupBox2.Controls.Add(this.redTrackBar);
            this.groupBox2.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Location = new System.Drawing.Point(290, 37);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(626, 203);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LED Brightness Controller";
            // 
            // greenButton
            // 
            this.greenButton.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.greenButton.Location = new System.Drawing.Point(464, 143);
            this.greenButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.greenButton.Name = "greenButton";
            this.greenButton.Size = new System.Drawing.Size(137, 39);
            this.greenButton.TabIndex = 5;
            this.greenButton.Text = "Set Intensity";
            this.greenButton.UseVisualStyleBackColor = true;
            this.greenButton.Click += new System.EventHandler(this.greenButton_Click);
            // 
            // greenTrackBar
            // 
            this.greenTrackBar.Location = new System.Drawing.Point(18, 153);
            this.greenTrackBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.greenTrackBar.Maximum = 255;
            this.greenTrackBar.Name = "greenTrackBar";
            this.greenTrackBar.Size = new System.Drawing.Size(441, 56);
            this.greenTrackBar.TabIndex = 4;
            this.greenTrackBar.TickFrequency = 15;
            this.greenTrackBar.Scroll += new System.EventHandler(this.greenTrackBar_Scroll);
            // 
            // yellowButton
            // 
            this.yellowButton.ForeColor = System.Drawing.Color.Goldenrod;
            this.yellowButton.Location = new System.Drawing.Point(464, 86);
            this.yellowButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.yellowButton.Name = "yellowButton";
            this.yellowButton.Size = new System.Drawing.Size(137, 39);
            this.yellowButton.TabIndex = 3;
            this.yellowButton.Text = "Set Intensity";
            this.yellowButton.UseVisualStyleBackColor = true;
            this.yellowButton.Click += new System.EventHandler(this.yellowButton_Click);
            // 
            // yellowTrackBar
            // 
            this.yellowTrackBar.Location = new System.Drawing.Point(18, 93);
            this.yellowTrackBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.yellowTrackBar.Maximum = 255;
            this.yellowTrackBar.Name = "yellowTrackBar";
            this.yellowTrackBar.Size = new System.Drawing.Size(441, 56);
            this.yellowTrackBar.TabIndex = 2;
            this.yellowTrackBar.TickFrequency = 15;
            this.yellowTrackBar.Scroll += new System.EventHandler(this.yellowTrackBar_Scroll);
            // 
            // redButton
            // 
            this.redButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.redButton.Location = new System.Drawing.Point(464, 33);
            this.redButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(137, 39);
            this.redButton.TabIndex = 1;
            this.redButton.Text = "Set Intensity";
            this.redButton.UseVisualStyleBackColor = true;
            this.redButton.Click += new System.EventHandler(this.redButton_Click);
            // 
            // redTrackBar
            // 
            this.redTrackBar.Location = new System.Drawing.Point(18, 33);
            this.redTrackBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.redTrackBar.Maximum = 255;
            this.redTrackBar.Name = "redTrackBar";
            this.redTrackBar.Size = new System.Drawing.Size(441, 56);
            this.redTrackBar.TabIndex = 0;
            this.redTrackBar.TickFrequency = 15;
            this.redTrackBar.Scroll += new System.EventHandler(this.redTrackBar_Scroll);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox4.Controls.Add(this.setServoAngleButton);
            this.groupBox4.Controls.Add(this.resetButton);
            this.groupBox4.Controls.Add(this.servoRichTextBox);
            this.groupBox4.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox4.Location = new System.Drawing.Point(44, 213);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(209, 262);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Servo Controller";
            // 
            // servoRichTextBox
            // 
            this.servoRichTextBox.Font = new System.Drawing.Font("Malgun Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servoRichTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.servoRichTextBox.Location = new System.Drawing.Point(23, 38);
            this.servoRichTextBox.Name = "servoRichTextBox";
            this.servoRichTextBox.Size = new System.Drawing.Size(158, 96);
            this.servoRichTextBox.TabIndex = 5;
            this.servoRichTextBox.Text = "";
            // 
            // resetButton
            // 
            this.resetButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.resetButton.Location = new System.Drawing.Point(23, 149);
            this.resetButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(158, 39);
            this.resetButton.TabIndex = 6;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // setServoAngleButton
            // 
            this.setServoAngleButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.setServoAngleButton.Location = new System.Drawing.Point(23, 204);
            this.setServoAngleButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.setServoAngleButton.Name = "setServoAngleButton";
            this.setServoAngleButton.Size = new System.Drawing.Size(158, 39);
            this.setServoAngleButton.TabIndex = 7;
            this.setServoAngleButton.Text = "Set Angle";
            this.setServoAngleButton.UseVisualStyleBackColor = true;
            this.setServoAngleButton.Click += new System.EventHandler(this.setServoAngleButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 507);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.greenTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redTrackBar)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox redLEDCheckbox;
        private System.Windows.Forms.CheckBox yellowLEDCheckbox;
        private System.Windows.Forms.CheckBox greenLEDCheckbox;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button yellowButton;
        private System.Windows.Forms.TrackBar yellowTrackBar;
        private System.Windows.Forms.Button redButton;
        private System.Windows.Forms.TrackBar redTrackBar;
        private System.Windows.Forms.TrackBar greenTrackBar;
        private System.Windows.Forms.Button greenButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox servoRichTextBox;
        private System.Windows.Forms.Button setServoAngleButton;
        private System.Windows.Forms.Button resetButton;
    }
}

