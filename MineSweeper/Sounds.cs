using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace MineSweeper
{
    class Sounds
    {
        public void playBombSound() 
        {
            SoundPlayer audio = new SoundPlayer(MineSweeper.Resource1.bomb);
            audio.Play();
        }

    }
}
