using System;
using System.Collections.Generic;
using System.Text;
using WMPLib;

namespace WF1_Training.Properties
{
    public static class AudioManager
    {
        private static WindowsMediaPlayer player = new WindowsMediaPlayer();

        public static bool IsMuted { get; private set; } = false;
        public static int Volume { get; private set; } = 70;

        public static void Play(string path)
        {
            player.URL = path;
            player.settings.volume = Volume;
            player.settings.mute = IsMuted;
            player.settings.setMode("loop", true);
            player.controls.play();
        }

        public static void Stop()
        {
            player.controls.stop();
        }

        public static void SetVolume(int volume)
        {
            Volume = volume;
            player.settings.volume = volume;
        }

        public static void Mute(bool mute)
        {
            IsMuted = mute;
            player.settings.mute = mute;
        }
    }
}
