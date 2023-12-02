using MyWebSiteCaseTests.Framework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebSiteCaseTests.Framework.Creators
{
    public static class QualityCreator
    {
        public static string dataQuality = "720p60";

        public static Quality Create()
        {
            return new Quality(dataQuality);
        }
    }
}
