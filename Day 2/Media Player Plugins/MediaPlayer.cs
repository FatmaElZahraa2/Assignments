using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Player_Plugins
{
    internal class MediaPlayer
    {
        IMedia[] tracks = new IMedia[10];
        int idx = 0;
        
        public void AddTrack(IMedia trc)
        {
            if (idx < tracks.Length)
            {
                tracks[idx++] = trc;
                Console.WriteLine("Track was added");
            }
                
            else
                Console.WriteLine("There is no enough space");
        }

        public void StartTrack(IMedia trc)
        {
            trc.Play();
        }

        public void StopTrack(IMedia trc)
        {
            trc.Stop();
        }

    }
}
