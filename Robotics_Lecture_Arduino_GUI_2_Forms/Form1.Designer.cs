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
            this.setServoAngleButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.servoRichTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.vibrateServoButton = new System.Windows.Forms.RadioButton();
            this.beepBuzzerButton = new System.Windows.Forms.RadioButton();
            this.blinkLEDsButton = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.playSong = new System.Windows.Forms.Button();
            this.songStatusLabel = new System.Windows.Forms.Label();
            this.nowPlayingText = new System.Windows.Forms.Label();
            this.songComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.greenTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redTrackBar)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
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
            this.groupBox2.Size = new System.Drawing.Size(595, 203);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LED Brightness Controller";
            // 
            // greenButton
            // 
            this.greenButton.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.greenButton.Location = new System.Drawing.Point(435, 141);
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
            this.greenTrackBar.Size = new System.Drawing.Size(411, 56);
            this.greenTrackBar.TabIndex = 4;
            this.greenTrackBar.TickFrequency = 15;
            this.greenTrackBar.Scroll += new System.EventHandler(this.greenTrackBar_Scroll);
            // 
            // yellowButton
            // 
            this.yellowButton.ForeColor = System.Drawing.Color.Goldenrod;
            this.yellowButton.Location = new System.Drawing.Point(435, 81);
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
            this.yellowTrackBar.Size = new System.Drawing.Size(411, 56);
            this.yellowTrackBar.TabIndex = 2;
            this.yellowTrackBar.TickFrequency = 15;
            this.yellowTrackBar.Scroll += new System.EventHandler(this.yellowTrackBar_Scroll);
            // 
            // redButton
            // 
            this.redButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.redButton.Location = new System.Drawing.Point(435, 27);
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
            this.redTrackBar.Size = new System.Drawing.Size(411, 56);
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
            // setServoAngleButton
            // 
            this.setServoAngleButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.setServoAngleButton.Location = new System.Drawing.Point(23, 149);
            this.setServoAngleButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.setServoAngleButton.Name = "setServoAngleButton";
            this.setServoAngleButton.Size = new System.Drawing.Size(158, 39);
            this.setServoAngleButton.TabIndex = 7;
            this.setServoAngleButton.Text = "Set Angle";
            this.setServoAngleButton.UseVisualStyleBackColor = true;
            this.setServoAngleButton.Click += new System.EventHandler(this.setServoAngleButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.resetButton.Location = new System.Drawing.Point(19, 204);
            this.resetButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(158, 39);
            this.resetButton.TabIndex = 6;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
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
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox3.Controls.Add(this.vibrateServoButton);
            this.groupBox3.Controls.Add(this.beepBuzzerButton);
            this.groupBox3.Controls.Add(this.blinkLEDsButton);
            this.groupBox3.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox3.Location = new System.Drawing.Point(290, 273);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(234, 202);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Output Actions";
            // 
            // vibrateServoButton
            // 
            this.vibrateServoButton.AutoSize = true;
            this.vibrateServoButton.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vibrateServoButton.Location = new System.Drawing.Point(39, 144);
            this.vibrateServoButton.Name = "vibrateServoButton";
            this.vibrateServoButton.Size = new System.Drawing.Size(167, 27);
            this.vibrateServoButton.TabIndex = 2;
            this.vibrateServoButton.TabStop = true;
            this.vibrateServoButton.Text = "Rotate Servo Arm";
            this.vibrateServoButton.UseVisualStyleBackColor = true;
            this.vibrateServoButton.CheckedChanged += new System.EventHandler(this.vibrateServoButton_CheckedChanged);
            // 
            // beepBuzzerButton
            // 
            this.beepBuzzerButton.AutoSize = true;
            this.beepBuzzerButton.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beepBuzzerButton.Location = new System.Drawing.Point(39, 95);
            this.beepBuzzerButton.Name = "beepBuzzerButton";
            this.beepBuzzerButton.Size = new System.Drawing.Size(126, 27);
            this.beepBuzzerButton.TabIndex = 1;
            this.beepBuzzerButton.TabStop = true;
            this.beepBuzzerButton.Text = "Beep Buzzer";
            this.beepBuzzerButton.UseVisualStyleBackColor = true;
            this.beepBuzzerButton.CheckedChanged += new System.EventHandler(this.beepBuzzerButton_CheckedChanged);
            // 
            // blinkLEDsButton
            // 
            this.blinkLEDsButton.AutoSize = true;
            this.blinkLEDsButton.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blinkLEDsButton.Location = new System.Drawing.Point(39, 47);
            this.blinkLEDsButton.Name = "blinkLEDsButton";
            this.blinkLEDsButton.Size = new System.Drawing.Size(110, 27);
            this.blinkLEDsButton.TabIndex = 0;
            this.blinkLEDsButton.TabStop = true;
            this.blinkLEDsButton.Text = "Blink LEDs";
            this.blinkLEDsButton.UseVisualStyleBackColor = true;
            this.blinkLEDsButton.CheckedChanged += new System.EventHandler(this.blinkLEDsButton_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox5.Controls.Add(this.playSong);
            this.groupBox5.Controls.Add(this.songStatusLabel);
            this.groupBox5.Controls.Add(this.nowPlayingText);
            this.groupBox5.Controls.Add(this.songComboBox);
            this.groupBox5.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox5.Location = new System.Drawing.Point(558, 273);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(327, 202);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Song Player";
            // 
            // playSong
            // 
            this.playSong.Location = new System.Drawing.Point(88, 95);
            this.playSong.Name = "playSong";
            this.playSong.Size = new System.Drawing.Size(153, 39);
            this.playSong.TabIndex = 3;
            this.playSong.Text = "Play Song";
            this.playSong.UseVisualStyleBackColor = true;
            this.playSong.Click += new System.EventHandler(this.playSong_Click);
            // 
            // songStatusLabel
            // 
            this.songStatusLabel.AutoSize = true;
            this.songStatusLabel.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songStatusLabel.Location = new System.Drawing.Point(6, 160);
            this.songStatusLabel.Name = "songStatusLabel";
            this.songStatusLabel.Size = new System.Drawing.Size(139, 23);
            this.songStatusLabel.TabIndex = 2;
            this.songStatusLabel.Text = "No Song Playing";
            // 
            // nowPlayingText
            // 
            this.nowPlayingText.AutoSize = true;
            this.nowPlayingText.Location = new System.Drawing.Point(101, 121);
            this.nowPlayingText.Name = "nowPlayingText";
            this.nowPlayingText.Size = new System.Drawing.Size(0, 23);
            this.nowPlayingText.TabIndex = 1;
            // 
            // songComboBox
            // 
            this.songComboBox.FormattingEnabled = true;
            this.songComboBox.Items.AddRange(new object[] {
            "La Vien Rose",
            "Fly Me to the Moon"});
            this.songComboBox.Location = new System.Drawing.Point(22, 47);
            this.songComboBox.Name = "songComboBox";
            this.songComboBox.Size = new System.Drawing.Size(276, 31);
            this.songComboBox.TabIndex = 0;
            this.songComboBox.SelectedIndexChanged += new System.EventHandler(this.songComboBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 507);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
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
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton vibrateServoButton;
        private System.Windows.Forms.RadioButton beepBuzzerButton;
        private System.Windows.Forms.RadioButton blinkLEDsButton;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox songComboBox;
        private System.Windows.Forms.Label songStatusLabel;
        private System.Windows.Forms.Label nowPlayingText;
        private System.Windows.Forms.Button playSong;
    }
}

