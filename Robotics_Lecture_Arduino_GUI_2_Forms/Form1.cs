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
                serialPort1.Write("Birthday");
                songStatusLabel.Text = "Now Playing Happy Birthday";
            }

            if (selectedSong.Equals("Ba Ba Black Sheep"))
            {
                serialPort1.Write("Sheep");
                songStatusLabel.Text = "Now Playing Ba Ba Black Sheep";
            }
            if (selectedSong.Equals("Twinkle Twinkle Little Star"))
            {
                serialPort1.Write("Twinkle");
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
    }
}
