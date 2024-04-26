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
        private String redIntensity = "";
        private String yellowIntensity = "";
        private String greenIntensity = "";
        private String selectedSong = "";

        public Form1()
        {
            InitializeComponent();
            serialPort1.Open();
        }

        private void redLEDCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (redLEDCheckbox.Checked)
            {
                serialPort1.Write("ROn");
            }
            else
            {
                serialPort1.Write("ROff");
            }
        }

        private void yellowLEDCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (yellowLEDCheckbox.Checked)
            {
                serialPort1.Write("YOn");
            }
            else
            {
                serialPort1.Write("YOff");
            }
        }

        private void greenCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (greenLEDCheckbox.Checked)
            {
                serialPort1.Write("GOn");
            }
            else
            {
                serialPort1.Write("GOff");
            }

        }

        private void redTrackBar_Scroll(object sender, EventArgs e)
        {
            redIntensity = "RI" + redTrackBar.Value;
        }

        private void redButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(redIntensity))
            {
                serialPort1.Write("RI0");
            }
            serialPort1.Write(redIntensity);
        }

        private void yellowTrackBar_Scroll(object sender, EventArgs e)
        {
            yellowIntensity = "YI" + yellowTrackBar.Value;
        }

        private void yellowButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(yellowIntensity))
            {
                serialPort1.Write("YI0");
            }

            serialPort1.Write(yellowIntensity);
        }

        private void greenTrackBar_Scroll(object sender, EventArgs e)
        {
            greenIntensity = "GI" + greenTrackBar.Value;
        }

        private void greenButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(greenIntensity))
            {
                serialPort1.Write("GI0");
            }
            serialPort1.Write(greenIntensity);
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            serialPort1.Write("Servo0");
        }

        private void setServoAngleButton_Click(object sender, EventArgs e)
        {
            serialPort1.Write("Servo" + servoRichTextBox.Text);
        }

        private void blinkLEDsButton_CheckedChanged(object sender, EventArgs e)
        {
            if (blinkLEDsButton.Checked)
            {
                serialPort1.Write("Blnk");
            }
            else
            {
                blinkLEDsButton.Checked = false;
            }
        }

        private void beepBuzzerButton_CheckedChanged(object sender, EventArgs e)
        {
            if (beepBuzzerButton.Checked)
            {
                serialPort1.Write("Beep");
            }
            else
            {
                beepBuzzerButton.Checked = false;
            }
        }

        private void vibrateServoButton_CheckedChanged(object sender, EventArgs e)
        {
            if (vibrateServoButton.Checked)
            {
                serialPort1.Write("Vibrate");
            }
            else
            {
                vibrateServoButton.Checked = false;
            }
        }

        private void songComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedSong = songComboBox.SelectedItem.ToString();
        }

        private void playSong_Click(object sender, EventArgs e)
        {
            if (selectedSong.Equals("La Vien Rose"))
            {
                serialPort1.Write("FirstSong");
                songStatusLabel.Text = "Now Playing La Vien Rose";
            }

            if (selectedSong.Equals("Fly Me to the Moon"))
            {
                serialPort1.Write("SecondSong");
                songStatusLabel.Text = "Now Playing Fly Me to the Moon";
            }

        }

    }
}
