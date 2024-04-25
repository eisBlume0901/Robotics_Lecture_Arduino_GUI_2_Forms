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
            this.redLEDCheckbox = new System.Windows.Forms.CheckBox();
            this.yellowLEDCheckbox = new System.Windows.Forms.CheckBox();
            this.greenLEDCheckbox = new System.Windows.Forms.CheckBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(339, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 238);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LED Selector";
            // 
            // redLEDCheckbox
            // 
            this.redLEDCheckbox.AutoSize = true;
            this.redLEDCheckbox.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redLEDCheckbox.ForeColor = System.Drawing.Color.OrangeRed;
            this.redLEDCheckbox.Location = new System.Drawing.Point(26, 40);
            this.redLEDCheckbox.Name = "redLEDCheckbox";
            this.redLEDCheckbox.Size = new System.Drawing.Size(163, 32);
            this.redLEDCheckbox.TabIndex = 0;
            this.redLEDCheckbox.Text = "Turn Red LED";
            this.redLEDCheckbox.UseVisualStyleBackColor = true;
            this.redLEDCheckbox.CheckedChanged += new System.EventHandler(this.redLEDCheckbox_CheckedChanged);
            // 
            // yellowLEDCheckbox
            // 
            this.yellowLEDCheckbox.AutoSize = true;
            this.yellowLEDCheckbox.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yellowLEDCheckbox.ForeColor = System.Drawing.Color.Goldenrod;
            this.yellowLEDCheckbox.Location = new System.Drawing.Point(26, 78);
            this.yellowLEDCheckbox.Name = "yellowLEDCheckbox";
            this.yellowLEDCheckbox.Size = new System.Drawing.Size(187, 32);
            this.yellowLEDCheckbox.TabIndex = 1;
            this.yellowLEDCheckbox.Text = "Turn Yellow LED";
            this.yellowLEDCheckbox.UseVisualStyleBackColor = true;
            this.yellowLEDCheckbox.CheckedChanged += new System.EventHandler(this.yellowLEDCheckbox_CheckedChanged);
            // 
            // greenLEDCheckbox
            // 
            this.greenLEDCheckbox.AutoSize = true;
            this.greenLEDCheckbox.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greenLEDCheckbox.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.greenLEDCheckbox.Location = new System.Drawing.Point(26, 127);
            this.greenLEDCheckbox.Name = "greenLEDCheckbox";
            this.greenLEDCheckbox.Size = new System.Drawing.Size(183, 32);
            this.greenLEDCheckbox.TabIndex = 2;
            this.greenLEDCheckbox.Text = "Turn Green LED";
            this.greenLEDCheckbox.UseVisualStyleBackColor = true;
            this.greenLEDCheckbox.CheckedChanged += new System.EventHandler(this.greenCheckBox_CheckedChanged);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 634);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox redLEDCheckbox;
        private System.Windows.Forms.CheckBox yellowLEDCheckbox;
        private System.Windows.Forms.CheckBox greenLEDCheckbox;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

