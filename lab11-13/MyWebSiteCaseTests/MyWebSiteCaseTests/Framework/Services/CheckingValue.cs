using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebSiteCaseTests.Framework.Services
{
    public static class CheckingValue
    {
        public static bool CheckVlaueInTypes(string value, params string[] parameters)
        {
            foreach (var parameter in parameters)
            {
                if(value == parameter) return true;
            }

            return false;
        }
    }
}
