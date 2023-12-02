using MyWebSiteCaseTests.Framework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebSiteCaseTests.Framework.Creators
{
    public static class LanguageCreator
    {
        public static string dataLanguage = "Русский";

        public static Language Create()
        {
            return new Language(dataLanguage);
        }
    }
}
