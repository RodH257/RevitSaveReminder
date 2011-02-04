using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using RodsUtilities;

namespace RevitSaveReminder
{
    /// <summary>
    /// Plays the sound configured in the app config
    /// </summary>

    public static class AlertSoundPlayer
    {
        /// <summary>
        /// Plays the alert sound
        /// </summary>
        public static void PlaySound()
        {
            //Check what sound is configured
            string soundConfigured = HostedConfiguration.GetConfigProperty("WavFile", typeof(AlertSoundPlayer));

          if (string.IsNullOrEmpty(soundConfigured))
              return;

            soundConfigured = soundConfigured.ToLower();

            if (soundConfigured.Contains(".wav"))
            {
                //its a full wav path.
                if (!File.Exists(soundConfigured))
                    return;

                SoundPlayer player = new SoundPlayer(soundConfigured);
                player.Play();
                return;
            }
            else
            {

                Assembly currentAssembly = Assembly.GetExecutingAssembly();
                //get the embedded wav file
                Stream soundStream = currentAssembly.GetManifestResourceStream(currentAssembly.GetName().Name + "." + soundConfigured + ".wav");
                SoundPlayer player = new SoundPlayer(soundStream);
                player.Play();
            }
        }
    }
}
