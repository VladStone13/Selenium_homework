using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Selenium_homework.page_objects
{
    class ContactPage : Page
    {
        private string title = "Learn more about EPAM and Contact Us | EPAM";

        public ContactPage(IWebDriver webDriver) : base(webDriver)
        {
        }

        public bool CheckTitle()
        {
            return title.Equals(GetTitle());
        }
    }
}
