using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Player_Plugins
{
    internal class Audio : IMedia
    {
       
        public void Play()
        {
            Console.WriteLine("Audio Played");
        }
        public void Stop()
        {
            Console.WriteLine("Audio Stopped");
        }
    }
}
