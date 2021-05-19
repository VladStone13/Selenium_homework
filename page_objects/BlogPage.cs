using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Selenium_homework.page_objects
{

    class BlogPage : Page
    {

        private string title = "Flip the Script Careers Blog | EPAM";
        private By searchBy = By.CssSelector("div[class='title'] > h1");

        public BlogPage(IWebDriver webDriver) : base(webDriver)
        {}

        public bool CheckTitle()
        {
            return title.Equals(GetTitle());
        }

        public bool CheckCenterTitle(string titleText)
        {
            IWebElement centerTitle = webDriver.FindElement(searchBy);
            return titleText.Equals(centerTitle.Text);
        }
    }
}
