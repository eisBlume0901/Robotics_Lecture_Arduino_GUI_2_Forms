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
        private String redValue = "";
        private String yellowValue = "";
        private String greenValue = "";
        private String selectedSong = "";
        private String birthdayVol = "";
        private String sheepVol = "";
        private String twinkleVol = "";

        public Form1()
        {
            InitializeComponent();
            serialPort1.Open(); //COM3
        }



        private void songComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedSong = songComboBox.SelectedItem.ToString();
        }

        private void playSong_Click(object sender, EventArgs e)
        {
            /*
             * Happy Birthday
Ba Ba Black Sheep
Twinkle Twinkle Little Star
             */
            if (selectedSong.Equals("Happy Birthday"))
            {
                birthdayVol = "Birthday";
                songStatusLabel.Text = "Now Playing Happy Birthday";
            }

            if (selectedSong.Equals("Ba Ba Black Sheep"))
            {
                sheepVol = "Sheep";
                songStatusLabel.Text = "Now Playing Ba Ba Black Sheep";
            }
            if (selectedSong.Equals("Twinkle Twinkle Little Star"))
            {
                twinkleVol = "Twinkle";
                songStatusLabel.Text = "Now Playing Twinkle Twinkle Little Star";
            }

        }

        private void move45Degrees_CheckedChanged(object sender, EventArgs e)
        {
            if (move45Degrees.Checked)
            {
                serialPort1.Write("S45");
            }
        }

        private void move90Degrees_CheckedChanged(object sender, EventArgs e)
        {
            if (move90Degrees.Checked)
            {
                serialPort1.Write("S90");
            }
        }

        private void move180Degrees_CheckedChanged(object sender, EventArgs e)
        {
            if (move180Degrees.Checked)
            {
                serialPort1.Write("S180");
            }
        }

        private void sendRedData_Click(object sender, EventArgs e)
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

        private void sendYellowData_Click(object sender, EventArgs e)
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

        private void sendGreenData_Click(object sender, EventArgs e)
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

        private void move0Degrees_Click(object sender, EventArgs e)
        {
            serialPort1.Write("S0");
        }

    
        private void volumeTrackBar_Scroll(object sender, EventArgs e)
        {
            birthdayVol += Convert.ToString(volumeTrackBar.Value);
            sheepVol += Convert.ToString(volumeTrackBar.Value);
            twinkleVol += Convert.ToString(volumeTrackBar.Value);

        }

        private void sendVolumeButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(birthdayVol))
            {
                serialPort1.Write("Birthday0");
            }
            else
            {
                serialPort1.Write(birthdayVol);

            }

            if (String.IsNullOrEmpty(sheepVol))
            {
                serialPort1.Write("Sheep0");
            }
            else
            {
                serialPort1.Write(sheepVol);

            }

            if (String.IsNullOrEmpty(twinkleVol))
            {
                serialPort1.Write("Twinkle0");
            }
            else
            {
                serialPort1.Write(twinkleVol);

            }



        }
    }
}
