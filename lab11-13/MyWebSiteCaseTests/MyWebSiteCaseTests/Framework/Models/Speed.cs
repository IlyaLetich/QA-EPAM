using MyWebSiteCaseTests.Framework.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebSiteCaseTests.Framework.Models
{
    public class Speed
    {
        private string speedVideo;

        public string SpeedVideo
        {
            get
            {
                return speedVideo;
            }
            set
            {
                if (CheckingValue.CheckVlaueInTypes(value, "0.5x", "1x", "2x"))
                    speedVideo = value;
            }
        }

        public Speed(string quality)
        {
            this.SpeedVideo = quality;
        }
    }
}
