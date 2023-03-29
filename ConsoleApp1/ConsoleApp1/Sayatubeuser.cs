using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace jurnalmod6_1302210047
{
    internal class Sayatubeuser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        private string username;
        public Sayatubeuser(string title)
        {
            username= title;
            uploadedVideos = new List<SayaTubeVideo>();

        }
        public int GetTotalVideoPlayCount ()
        {
            int count = 0;
            
            foreach (SayaTubeVideo video in uploadedVideos)
            {
                count += video.GetPlayCount();
            }
            return count;
            
        }
        public void AddVideo(SayaTubeVideo video) 
        {
            uploadedVideos.Add(video);  
        }
        
        
    }
}
