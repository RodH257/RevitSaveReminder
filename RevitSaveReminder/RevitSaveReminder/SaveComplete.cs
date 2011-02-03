using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RevitSaveReminder
{
    public partial class SaveComplete : Form
    {
        public SaveComplete()
        {
            InitializeComponent();
        }

        private void SaveComplete_Load(object sender, EventArgs e)
        {
            //When the form is shown, flash the taskbar 
            FlashWindow.Start(this);

            //play the sound
            AlertSoundPlayer.PlaySound();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            //Stop the flashing
            FlashWindow.Stop(this);
            this.Close();
        }
    }
}
