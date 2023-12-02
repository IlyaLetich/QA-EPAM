using MyWebSiteCaseTests.Framework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebSiteCaseTests.Framework.Creators
{
    public static class CategoryCreator
    {
        public static string dataCategory = "Музыка - Twitch";

        public static Category Create()
        {
            return new Category(dataCategory);
        }
    }
}
