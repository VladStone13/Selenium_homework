using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Selenium_homework.page_objects
{
    class HowWeDoItPage : Page
    {
        private string title = "How We Do It | Agile Product Engineering Services | EPAM";
        private By homeButtonSelector = By.CssSelector(".header__logo-container");

        public HowWeDoItPage(IWebDriver webDriver) : base(webDriver)
        {
        }

        public bool CheckTitle()
        {
            return title.Equals(GetTitle());
        }

        public void OpenHomePage()
        {
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            IWebElement homePageButton = webDriver.FindElement(homeButtonSelector);
            homePageButton.Click();
        }
    }
}
