using MyWebSiteCaseTests.Framework.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebSiteCaseTests.Framework.Models
{
    public class Error
    {
        private string errorMessage;

        public string ErrorMessage
        {
            get
            {
                return errorMessage;
            }
            set
            {
                if (CheckingValue.CheckVlaueInTypes(value, "«Заикание» звука и изображения", "Изображение «заикается», но со звуком все в порядке", "Звук и видео не синхронизированы", "Не удается включить воспроизведение рекламы", "Реклама не соответствует моим интересам"))
                    errorMessage = value;
            }
        }

        public Error(string error)
        {
            this.ErrorMessage = error;
        }
    }
}
