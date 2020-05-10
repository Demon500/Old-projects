using System.Media;
using Labirint_2D.Properties;

namespace Labirint_2D
{
     public  static class Sounds
    {
         static SoundPlayer Start_S = new SoundPlayer(Resources.Windows_Logon_Sound);
         static SoundPlayer Win_S= new SoundPlayer(Resources.tada);
         static SoundPlayer Luse_S = new SoundPlayer(Resources.Start);
         static SoundPlayer Key_S = new SoundPlayer(Resources.Windows_Shutdown);

         public static void PlaySound(int State, bool SoundState)
         {
             if (SoundState == true)
             {
                 switch (State)
                 {
                     case 1:
                         Start_S.Play();//start song play
                         break;
                     case 2:
                         Win_S.Play();
                         break;
                     case 3:
                         Luse_S.Play();
                         break;
                     case 4:
                         Key_S.Play();
                         break;
                 }
             }
         }
    }
}
