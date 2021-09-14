using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongGiuXe.Utils
{
    enum Sound
    {
        Thanks,
        UsedCard,
        InvalidCard,
        Accept
    }
    class SystemSound
    {
        public static void play(Sound sound)
        {
            System.IO.UnmanagedMemoryStream soundFile = null;
            switch (sound)
            {
                case Sound.Thanks:
                    soundFile = Properties.Resources.thankSound;
                    break;
                case Sound.UsedCard:
                    soundFile = Properties.Resources.usedCardSound;
                    break;
                case Sound.InvalidCard:
                    soundFile = Properties.Resources.invalidCardSound;
                    break;
                case Sound.Accept:
                    soundFile = Properties.Resources.acceptSound;
                    break;
            }
            using (var soundPlayer = new System.Media.SoundPlayer(soundFile))
            {
                soundPlayer.Play();
            }
        }
    }
}
