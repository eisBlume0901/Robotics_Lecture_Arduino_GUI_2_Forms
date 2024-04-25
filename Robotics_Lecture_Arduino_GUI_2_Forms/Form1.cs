using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Robotics_Lecture_Arduino_GUI_2_Forms
{
    public partial class Form1 : Form
    {
        private String redIntensity;
        private String yellowIntensity;
        private String greenIntensity;

        public Form1()
        {
            InitializeComponent();
            serialPort1.Open();
        }

        private void redLEDCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (redLEDCheckbox.Checked)
            {
                serialPort1.Write("Red Led");
            }
            else
            {
                serialPort1.Write("Red Led Off");
            }
        }

        private void yellowLEDCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (yellowLEDCheckbox.Checked)
            {
                serialPort1.Write("Yellow Led");
            }
            else
            {
                serialPort1.Write("Yellow Led Off");
            }
        }

        private void greenCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (greenLEDCheckbox.Checked)
            {
                serialPort1.Write("Green Led");
            }
            else
            {
                serialPort1.Write("Green Led Off");
            }

        }

        private void redTrackBar_Scroll(object sender, EventArgs e)
        {
            redIntensity = "Red Intensity" + redTrackBar.Value;
        }

        private void redButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(redIntensity))
            {
                serialPort1.Write("Red Intensity 0");
            }

            serialPort1.Write(redIntensity);
        }

        private void yellowTrackBar_Scroll(object sender, EventArgs e)
        {
            yellowIntensity = "Yellow Intensity" + yellowTrackBar.Value;
        }

        private void yellowButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty (yellowIntensity))
            {
                serialPort1.Write("Yellow Intensity 0");
            }

            serialPort1.Write(yellowIntensity);
        }

        private void greenTrackBar_Scroll(object sender, EventArgs e)
        {
            greenIntensity = "Green Intensity" + greenTrackBar.Value;
        }

        private void greenButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(greenIntensity))
            {
                serialPort1.Write("Green Intensity 0");
            }
            serialPort1.Write(greenIntensity);
        }
    }
}
