/***************************************************************************************
* Project name  : TheHungryRabbit2                                                     *
* Project type  : win64 console app                                                    *
* File_name     : TheHungryRabbit2                                                     *
* Language      : c#. MSVS 2017 and above                                              *
* Programmers   : Razenkov A. A.                                                       *
* Modified      : -                                                                    *
* Created       : 25.03.19                                                             *
* Last Revision : 30.05.19                                                             *
* Comment       : Sound                                                                *
***************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace TheHungryRabbit2
{
    static class Sound
    {
        //Подключение музыки
        static SoundPlayer SoundCrunch = new SoundPlayer(Properties.Resources.Crunch);
        static SoundPlayer SoundNyam = new SoundPlayer(Properties.Resources.Nyam);
        static SoundPlayer SoundUra = new SoundPlayer(Properties.Resources.Ura);
        static SoundPlayer SoundWeeping = new SoundPlayer(Properties.Resources.Weeping);
        static SoundPlayer SoundOpening = new SoundPlayer(Properties.Resources.Opening);
        static bool SoundEnabled = true;
        //Вкл/Выкл
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
            if (SoundEnabled)
                SoundCrunch.Play();
        }

        public static void PlayNyam()
        {
            if (SoundEnabled)
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

        public static void PlayOpening()
        {
            if (SoundEnabled)
                SoundOpening.Play();
        }
    }
}
