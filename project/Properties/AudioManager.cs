using System;
using System.Collections.Generic;
using System.Media;
using System.Text;
using WMPLib;

namespace Project.Properties
{
    public enum SFXType
    {
        ButtonHover,
        ShopHover,
        ButtonClick,
        Shoot,
        Explosion,
        PowerUp,
        Collect,
        GameOver
    }
    public static class AudioManager
    {
        private static readonly Dictionary<SFXType, string> sfxPaths = new Dictionary<SFXType, string>
        {
            { SFXType.ButtonHover,  @"Music\SFX\Options.wav" },
            { SFXType.ShopHover,  @"Music\SFX\Options.wav" },
            { SFXType.ButtonClick,  @"Assets\SFX\btn_click.wav" },
            { SFXType.Shoot,        @"Assets\SFX\shoot.wav" },
            { SFXType.Explosion,    @"Assets\SFX\explosion.wav" },
            { SFXType.PowerUp,      @"Assets\SFX\powerup.wav" },
            { SFXType.Collect,      @"Assets\SFX\collect.wav" },
            { SFXType.GameOver,     @"Assets\SFX\gameover.wav" }
        };


        private static WindowsMediaPlayer musicPlayer = new WindowsMediaPlayer();
        private static WindowsMediaPlayer sfxPlayer = new WindowsMediaPlayer();

        public static bool IsMusicMuted { get; private set; } = false;
        public static bool IsSFXMuted { get; private set; } = false;
        public static int MusicVolume { get; private set; } = 70;
        public static int SFXVolume { get; private set; } = 70;

        public static void PlayMusic(string path)
        {
            musicPlayer.URL = path;
            musicPlayer.settings.volume = MusicVolume;
            musicPlayer.settings.mute = IsMusicMuted;
            musicPlayer.settings.setMode("loop", true);
            musicPlayer.controls.play();
        }

        public static void PlaySFX(SFXType type)
        {
            if (IsSFXMuted)
                return;

            if (sfxPaths.TryGetValue(type, out string path))
            {
                sfxPlayer.URL = path;
                sfxPlayer.settings.volume = SFXVolume;
                sfxPlayer.settings.mute = IsSFXMuted;
                sfxPlayer.controls.play();
            }
        }

        public static void StopMusic() => musicPlayer.controls.stop();
        public static void StopSFX() => sfxPlayer.controls.stop();

        public static void SetMusicVolume(int volume)
        {
            MusicVolume = volume;
            musicPlayer.settings.volume = volume;
        }

        public static void SetSFXVolume(int volume)
        {
            SFXVolume = volume;
            sfxPlayer.settings.volume = volume;
        }

        public static void MuteMusic(bool mute)
        {
            IsMusicMuted = mute;
            musicPlayer.settings.mute = mute;
        
        }

        public static void MuteSFX(bool mute)
        {
            IsSFXMuted = mute;
            sfxPlayer.settings.mute = mute;
        }
        public static void ResumeMusic()
        {
            if (!IsMusicMuted)
                musicPlayer.controls.play();
        }
    }

}
