using System;
using System.Collections.Generic;
using System.Media;
using System.Text;
using WMPLib;
using System.Linq;

namespace Project.Properties
{
    public enum SFXType
    {
        ButtonHover,
        ShopHover,
        Shoot,
        Explosion,
        Collect,
        GameOver,
        Winner
    }
    public static class AudioManager
    {
        private static readonly Dictionary<SFXType, string> sfxPaths = new Dictionary<SFXType, string>
        {
            { SFXType.ButtonHover,  @"Music\SFX\Options.wav" },
            { SFXType.ShopHover,    @"Music\SFX\Options.wav" },
            { SFXType.Shoot,        @"Music\SFX\LaiserShooting.wav" },
            { SFXType.Explosion,    @"Music\SFX\boom.wav" },
            { SFXType.Collect,      @"Music\SFX\collect.wav" },
            { SFXType.GameOver,     @"Music\SFX\GameOver.wav" },
            { SFXType.Winner,       @"Music\SFX\win.wav" }
        };


        private static WindowsMediaPlayer musicPlayer = new WindowsMediaPlayer();
        //private static WindowsMediaPlayer sfxPlayer = new WindowsMediaPlayer();
        private const int PoolSize = 8;
        private static readonly List<WindowsMediaPlayer> sfxPool = new List<WindowsMediaPlayer>();
        private static int nextIndex = 0;

        public static bool IsMusicMuted { get; private set; } = false;
        public static bool IsSFXMuted { get; private set; } = false;
        public static int MusicVolume { get; private set; } = 70;
        public static int SFXVolume { get; private set; } = 70;

        static AudioManager()
        {
            for (int i = 0; i < PoolSize; i++)
            {
                var wmp = new WindowsMediaPlayer();
                wmp.settings.volume = SFXVolume;
                wmp.settings.mute = IsSFXMuted;
                sfxPool.Add(wmp);
            }
        }
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

            if (!sfxPaths.TryGetValue(type, out string path))
                return;

            var freePlayer = sfxPool.FirstOrDefault(p =>
                p.playState == WMPPlayState.wmppsStopped ||
                p.playState == WMPPlayState.wmppsUndefined ||
                p.playState == WMPPlayState.wmppsReady);

            var player = freePlayer ?? sfxPool[nextIndex];
            if (freePlayer == null)
                nextIndex = (nextIndex + 1) % sfxPool.Count;

            player.settings.volume = SFXVolume;
            player.settings.mute = IsSFXMuted;
            player.URL = path;
            player.controls.play();
        }

        public static void StopMusic() => musicPlayer.controls.stop();
        public static void StopSFX()
        {
            foreach (var p in sfxPool)
                p.controls.stop();
        }
        public static void SetMusicVolume(int volume)
        {
            MusicVolume = volume;
            musicPlayer.settings.volume = volume;
        }

        public static void SetSFXVolume(int volume)
        {
            SFXVolume = volume;
            foreach (var p in sfxPool)
                p.settings.volume = volume;
        }

        public static void MuteMusic(bool mute)
        {
            IsMusicMuted = mute;
            musicPlayer.settings.mute = mute;
        
        }

        public static void MuteSFX(bool mute)
        {
            IsSFXMuted = mute;
            foreach (var p in sfxPool)
                p.settings.mute = mute;
        }
        public static void ResumeMusic()
        {
            if (!IsMusicMuted)
                musicPlayer.controls.play();
        }
    }

}
