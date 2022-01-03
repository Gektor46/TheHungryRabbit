using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace TheHungryRabbit
{
    static class Sound
    {
        static SoundPlayer SoundCrunch = new SoundPlayer(Properties.Resources.Crunch);
        static SoundPlayer SoundNyam = new SoundPlayer(Properties.Resources.Nyam);
        static SoundPlayer SoundUra = new SoundPlayer(Properties.Resources.Ura);
        static SoundPlayer SoundWeeping = new SoundPlayer(Properties.Resources.Weeping);
        static bool SoundEnabled = true;

        public static void SoundOn()
        {
            SoundEnabled = true;
        }

        public static void SoundOff()
        {
            SoundEnabled = false;
        }

        //Методы воспроизведения
        public static void PlayCrunch()
        {
            if(SoundEnabled)
            SoundCrunch.Play();
        }

        public static void PlayNyam()
        {
            if(SoundEnabled)
            SoundNyam.Play();
        }

        public static void PlayUra()
        {
            if (SoundEnabled)
            SoundUra.Play();
        }

        public static void PlayWeeping()
        {
            if (SoundEnabled)
            SoundWeeping.Play();
        }
    }
}
