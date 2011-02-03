using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;

namespace RevitSaveReminder
{
    /// <summary>
    /// Plays the sound configures
    /// </summary>
    
    public static class AlertSoundPlayer
    {
        /// <summary>
        /// Plays the alert sound
        /// </summary>
        public static void PlaySound()
        {
            Assembly currentAssembly = Assembly.GetExecutingAssembly();
            Stream soundStream = currentAssembly.GetManifestResourceStream(currentAssembly.GetName().Name + ".applause_y.wav");
            SoundPlayer player = new SoundPlayer(soundStream);
            player.Play();
        }
    }
}
