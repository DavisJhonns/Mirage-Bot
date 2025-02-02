using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;
using System.IO;

namespace Mirage_Bot.Classes
{
    public static class Player
    {
        private static string LocalDir = new DirectoryInfo(Directory.GetCurrentDirectory() + @"\..\..\source\sound\").FullName;
        private static SoundPlayer Sp = new SoundPlayer();
        static string[] soundList = new string[4] { "select", "unselect", "load", "intro" };
        public static void Select() => Play(0);
        public static void Unselect() => Play(1);
        public static void Load() => Play(2);
        public static void Intro() => Play(3);
        private static void Play(int i)
        {
            Sp.SoundLocation = LocalDir + soundList[i] + ".wav";
            Sp.Play();
        }
    }
}
