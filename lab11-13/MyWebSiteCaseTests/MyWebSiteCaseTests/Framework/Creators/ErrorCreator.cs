using MyWebSiteCaseTests.Framework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebSiteCaseTests.Framework.Creators
{
    public static class ErrorCreator
    {
        public static string dataError = "Звук и видео не синхронизированы";

        public static Error Create()
        {
            return new Error(dataError);
        }
    }
}
