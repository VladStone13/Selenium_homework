using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Selenium_homework.page_objects
{
    class InstagramPage : Page
    {
        private string title = "EPAM Global (@epamsystems) • Фото и видео в Instagram";

        public InstagramPage(IWebDriver webDriver) : base(webDriver)
        {
        }

        public bool CheckTitle()
        {
            return title.Equals(GetTitle());
        }
    }
}
