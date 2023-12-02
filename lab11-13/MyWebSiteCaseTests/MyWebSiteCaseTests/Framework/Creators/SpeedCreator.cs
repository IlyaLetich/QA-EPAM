using MyWebSiteCaseTests.Framework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebSiteCaseTests.Framework.Creators
{
    public static class SpeedCreator
    {
        public static string dataSpeed = "2x";

        public static Speed Create()
        {
            return new Speed(dataSpeed);
        }
    }
}
