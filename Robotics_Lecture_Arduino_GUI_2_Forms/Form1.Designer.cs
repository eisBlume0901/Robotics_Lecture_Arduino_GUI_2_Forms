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
            this.sendGreenData = new System.Windows.Forms.Button();
            this.sendYellowData = new System.Windows.Forms.Button();
            this.sendRedData = new System.Windows.Forms.Button();
            this.greenLEDCheckbox = new System.Windows.Forms.CheckBox();
            this.yellowLEDCheckbox = new System.Windows.Forms.CheckBox();
            this.redLEDCheckbox = new System.Windows.Forms.CheckBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.move0Degrees = new System.Windows.Forms.Button();
            this.move180Degrees = new System.Windows.Forms.RadioButton();
            this.move90Degrees = new System.Windows.Forms.RadioButton();
            this.move45Degrees = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.playSong = new System.Windows.Forms.Button();
            this.songStatusLabel = new System.Windows.Forms.Label();
            this.nowPlayingText = new System.Windows.Forms.Label();
            this.songComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Bisque;
            this.groupBox1.Controls.Add(this.sendGreenData);
            this.groupBox1.Controls.Add(this.sendYellowData);
            this.groupBox1.Controls.Add(this.sendRedData);
            this.groupBox1.Controls.Add(this.greenLEDCheckbox);
            this.groupBox1.Controls.Add(this.yellowLEDCheckbox);
            this.groupBox1.Controls.Add(this.redLEDCheckbox);
            this.groupBox1.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(50, 46);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(640, 227);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LED Selector";
            // 
            // sendGreenData
            // 
            this.sendGreenData.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendGreenData.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.sendGreenData.Location = new System.Drawing.Point(342, 150);
            this.sendGreenData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sendGreenData.Name = "sendGreenData";
            this.sendGreenData.Size = new System.Drawing.Size(256, 49);
            this.sendGreenData.TabIndex = 6;
            this.sendGreenData.Text = "Send Green Data";
            this.sendGreenData.UseVisualStyleBackColor = true;
            this.sendGreenData.Click += new System.EventHandler(this.sendGreenData_Click);
            // 
            // sendYellowData
            // 
            this.sendYellowData.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendYellowData.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.sendYellowData.Location = new System.Drawing.Point(342, 88);
            this.sendYellowData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sendYellowData.Name = "sendYellowData";
            this.sendYellowData.Size = new System.Drawing.Size(256, 49);
            this.sendYellowData.TabIndex = 5;
            this.sendYellowData.Text = "Send Yellow Data";
            this.sendYellowData.UseVisualStyleBackColor = true;
            this.sendYellowData.Click += new System.EventHandler(this.sendYellowData_Click);
            // 
            // sendRedData
            // 
            this.sendRedData.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendRedData.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.sendRedData.Location = new System.Drawing.Point(342, 31);
            this.sendRedData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sendRedData.Name = "sendRedData";
            this.sendRedData.Size = new System.Drawing.Size(256, 49);
            this.sendRedData.TabIndex = 4;
            this.sendRedData.Text = "Send Red Data";
            this.sendRedData.UseVisualStyleBackColor = true;
            this.sendRedData.Click += new System.EventHandler(this.sendRedData_Click);
            // 
            // greenLEDCheckbox
            // 
            this.greenLEDCheckbox.AutoSize = true;
            this.greenLEDCheckbox.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greenLEDCheckbox.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.greenLEDCheckbox.Location = new System.Drawing.Point(26, 150);
            this.greenLEDCheckbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.greenLEDCheckbox.Name = "greenLEDCheckbox";
            this.greenLEDCheckbox.Size = new System.Drawing.Size(243, 42);
            this.greenLEDCheckbox.TabIndex = 2;
            this.greenLEDCheckbox.Text = "Turn Green LED";
            this.greenLEDCheckbox.UseVisualStyleBackColor = true;
            // 
            // yellowLEDCheckbox
            // 
            this.yellowLEDCheckbox.AutoSize = true;
            this.yellowLEDCheckbox.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yellowLEDCheckbox.ForeColor = System.Drawing.Color.Goldenrod;
            this.yellowLEDCheckbox.Location = new System.Drawing.Point(26, 95);
            this.yellowLEDCheckbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.yellowLEDCheckbox.Name = "yellowLEDCheckbox";
            this.yellowLEDCheckbox.Size = new System.Drawing.Size(250, 42);
            this.yellowLEDCheckbox.TabIndex = 1;
            this.yellowLEDCheckbox.Text = "Turn Yellow LED";
            this.yellowLEDCheckbox.UseVisualStyleBackColor = true;
            // 
            // redLEDCheckbox
            // 
            this.redLEDCheckbox.AutoSize = true;
            this.redLEDCheckbox.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redLEDCheckbox.ForeColor = System.Drawing.Color.OrangeRed;
            this.redLEDCheckbox.Location = new System.Drawing.Point(26, 40);
            this.redLEDCheckbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.redLEDCheckbox.Name = "redLEDCheckbox";
            this.redLEDCheckbox.Size = new System.Drawing.Size(216, 42);
            this.redLEDCheckbox.TabIndex = 0;
            this.redLEDCheckbox.Text = "Turn Red LED";
            this.redLEDCheckbox.UseVisualStyleBackColor = true;
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Bisque;
            this.groupBox3.Controls.Add(this.move0Degrees);
            this.groupBox3.Controls.Add(this.move180Degrees);
            this.groupBox3.Controls.Add(this.move90Degrees);
            this.groupBox3.Controls.Add(this.move45Degrees);
            this.groupBox3.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox3.Location = new System.Drawing.Point(741, 46);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(273, 331);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Servo Controller";
            // 
            // move0Degrees
            // 
            this.move0Degrees.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.move0Degrees.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.move0Degrees.Location = new System.Drawing.Point(35, 246);
            this.move0Degrees.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.move0Degrees.Name = "move0Degrees";
            this.move0Degrees.Size = new System.Drawing.Size(189, 49);
            this.move0Degrees.TabIndex = 7;
            this.move0Degrees.Text = "Reset";
            this.move0Degrees.UseVisualStyleBackColor = true;
            this.move0Degrees.Click += new System.EventHandler(this.move0Degrees_Click);
            // 
            // move180Degrees
            // 
            this.move180Degrees.AutoSize = true;
            this.move180Degrees.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.move180Degrees.Location = new System.Drawing.Point(44, 180);
            this.move180Degrees.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.move180Degrees.Name = "move180Degrees";
            this.move180Degrees.Size = new System.Drawing.Size(156, 34);
            this.move180Degrees.TabIndex = 2;
            this.move180Degrees.TabStop = true;
            this.move180Degrees.Text = "180 degrees";
            this.move180Degrees.UseVisualStyleBackColor = true;
            this.move180Degrees.CheckedChanged += new System.EventHandler(this.move180Degrees_CheckedChanged);
            // 
            // move90Degrees
            // 
            this.move90Degrees.AutoSize = true;
            this.move90Degrees.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.move90Degrees.Location = new System.Drawing.Point(44, 119);
            this.move90Degrees.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.move90Degrees.Name = "move90Degrees";
            this.move90Degrees.Size = new System.Drawing.Size(144, 34);
            this.move90Degrees.TabIndex = 1;
            this.move90Degrees.TabStop = true;
            this.move90Degrees.Text = "90 degrees";
            this.move90Degrees.UseVisualStyleBackColor = true;
            this.move90Degrees.CheckedChanged += new System.EventHandler(this.move90Degrees_CheckedChanged);
            // 
            // move45Degrees
            // 
            this.move45Degrees.AutoSize = true;
            this.move45Degrees.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.move45Degrees.Location = new System.Drawing.Point(44, 59);
            this.move45Degrees.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.move45Degrees.Name = "move45Degrees";
            this.move45Degrees.Size = new System.Drawing.Size(144, 34);
            this.move45Degrees.TabIndex = 0;
            this.move45Degrees.TabStop = true;
            this.move45Degrees.Text = "45 degrees";
            this.move45Degrees.UseVisualStyleBackColor = true;
            this.move45Degrees.CheckedChanged += new System.EventHandler(this.move45Degrees_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Bisque;
            this.groupBox5.Controls.Add(this.playSong);
            this.groupBox5.Controls.Add(this.songStatusLabel);
            this.groupBox5.Controls.Add(this.nowPlayingText);
            this.groupBox5.Controls.Add(this.songComboBox);
            this.groupBox5.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox5.Location = new System.Drawing.Point(50, 304);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(512, 252);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Song Player";
            // 
            // playSong
            // 
            this.playSong.Location = new System.Drawing.Point(150, 118);
            this.playSong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.playSong.Name = "playSong";
            this.playSong.Size = new System.Drawing.Size(172, 49);
            this.playSong.TabIndex = 3;
            this.playSong.Text = "Play Song";
            this.playSong.UseVisualStyleBackColor = true;
            this.playSong.Click += new System.EventHandler(this.playSong_Click);
            // 
            // songStatusLabel
            // 
            this.songStatusLabel.AutoSize = true;
            this.songStatusLabel.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songStatusLabel.Location = new System.Drawing.Point(32, 199);
            this.songStatusLabel.Name = "songStatusLabel";
            this.songStatusLabel.Size = new System.Drawing.Size(173, 30);
            this.songStatusLabel.TabIndex = 2;
            this.songStatusLabel.Text = "No Song Playing";
            // 
            // nowPlayingText
            // 
            this.nowPlayingText.AutoSize = true;
            this.nowPlayingText.Location = new System.Drawing.Point(114, 151);
            this.nowPlayingText.Name = "nowPlayingText";
            this.nowPlayingText.Size = new System.Drawing.Size(0, 28);
            this.nowPlayingText.TabIndex = 1;
            // 
            // songComboBox
            // 
            this.songComboBox.FormattingEnabled = true;
            this.songComboBox.Items.AddRange(new object[] {
            "Happy Birthday",
            "Ba Ba Black Sheep",
            "Twinkle Twinkle Little Star"});
            this.songComboBox.Location = new System.Drawing.Point(25, 59);
            this.songComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.songComboBox.Name = "songComboBox";
            this.songComboBox.Size = new System.Drawing.Size(447, 36);
            this.songComboBox.TabIndex = 0;
            this.songComboBox.SelectedIndexChanged += new System.EventHandler(this.songComboBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 692);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton move180Degrees;
        private System.Windows.Forms.RadioButton move90Degrees;
        private System.Windows.Forms.RadioButton move45Degrees;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox songComboBox;
        private System.Windows.Forms.Label songStatusLabel;
        private System.Windows.Forms.Label nowPlayingText;
        private System.Windows.Forms.Button playSong;
        private System.Windows.Forms.Button sendRedData;
        private System.Windows.Forms.Button sendGreenData;
        private System.Windows.Forms.Button sendYellowData;
        private System.Windows.Forms.Button move0Degrees;
    }
}

