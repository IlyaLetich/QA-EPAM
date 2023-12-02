using MyWebSiteCaseTests.Framework.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebSiteCaseTests.Framework.Models
{
    public class Language
    {
        private string languageVideos;

        public string LanguageVideos
        {
            get
            {
                return languageVideos;
            }
            set
            {
                if (CheckingValue.CheckVlaueInTypes(value, "Русский", "Deutsch", "English"))
                    languageVideos = value;
            }
        }

        public Language(string language)
        {
            this.LanguageVideos = language;
        }
    }
}
