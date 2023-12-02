using MyWebSiteCaseTests.Framework.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebSiteCaseTests.Framework.Models
{
    public class Category
    {
        private string categoryName;

        public string CategoryName
        {
            get
            {
                return categoryName;
            }
            set 
            {
                if (CheckingValue.CheckVlaueInTypes(value,"Игры", "IRL", "Музыка - Twitch", "Киберспорт", "Творчество"))
                    categoryName = value; 
            }
        }

        public Category(string category)
        {
            this.CategoryName = category;
        }
    }
}
