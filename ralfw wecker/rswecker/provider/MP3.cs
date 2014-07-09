using System;
using WMPLib;

namespace rswecker.provider
{
    class MP3
    {
        private readonly WMPLib.WindowsMediaPlayer _player = new WindowsMediaPlayer();

        public void Abspielen()
        {
            _player.URL = "media\\gong.mp3";
            _player.controls.play();
        }
    }
}
