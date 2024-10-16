using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Player_Plugins
{
    internal class Video :IMedia
    {
        public void Play()
        {
            Console.WriteLine("Video Played");
        }
        public void Stop()
        {
            Console.WriteLine("Video Stopped");
        }
    }
}
