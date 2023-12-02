using MyWebSiteCaseTests.Framework.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebSiteCaseTests.Framework.Models
{
    public class Quality
    {
        private string qualityVideo;

        public string QualityVideo
        {
            get
            {
                return qualityVideo;
            }
            set
            {
                if (CheckingValue.CheckVlaueInTypes(value, "160p", "360p", "480p", "720p60", "1080p60"))
                    qualityVideo = value;
            }
        }

        public Quality(string quality)
        {
            this.QualityVideo = quality;
        }
    }
}
