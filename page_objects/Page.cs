using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Selenium_homework.page_objects
{
    class Page
    {
        protected IWebDriver webDriver;

        public Page(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        public void OpenPage(String url)
        {
            webDriver.Url = url;
        }

        public String GetTitle()
        {
            return webDriver.Title;
        }
    }
}
