using System;
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
            //Set the time 
            this.SaveTitleLabel.Text = "Document synchronized with central at " + DateTime.Now.ToShortTimeString();

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
