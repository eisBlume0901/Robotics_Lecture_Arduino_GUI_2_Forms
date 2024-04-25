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
    }
}
