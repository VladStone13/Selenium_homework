using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Selenium_homework.page_objects
{
    class MainPage : Page
    {
        private By blogButtonSelector =By.CssSelector("a[href = '/careers/blog']");
        private By careerButtonSelector = By.CssSelector("a[href = '/careers']");
        private By howWeDoItButtonSelector = By.CssSelector("a[href = '/how-we-do-it']");
        private By selectorButtonSelector = By.CssSelector(".location-selector__button");
        private By ukrainianSelector = By.CssSelector("a[href = 'https://careers.epam.ua']");
        private By contactButtonSelector = By.CssSelector(".cta-button__text");
        private By instagramButtonSelector = By.CssSelector("a[href= 'https://www.instagram.com/epamsystems/']");
        private By searchButtonSelector = By.CssSelector(".header-search__button");
        private By inputFieldSelector = By.CssSelector(".header-search__input");
        private By findFieldSelector = By.CssSelector(".header-search__submit");

        private string title = "EPAM | Enterprise Software Development, Design & Consulting";

        public MainPage(IWebDriver webDriver) : base(webDriver)
        {
        }

        public void ClickSearchButton()
        {
            IWebElement searchButton = webDriver.FindElement(searchButtonSelector);
            searchButton.Click();
        }

        public void AcceptFind()
        {
            IWebElement findButton = webDriver.FindElement(findFieldSelector);
            findButton.Click();
        }

        public void AddText()
        {
            IWebElement textForm = webDriver.FindElement(inputFieldSelector);
            textForm.SendKeys("Blockchain");
        }

        public void ClickSelectorButton()
        {
            IWebElement selectorButton = webDriver.FindElement(selectorButtonSelector);
            selectorButton.Click();
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
        }

        public void OpenInstagram()
        {
            Actions actions = new Actions(webDriver);
            IWebElement instagramButton = webDriver.FindElement(instagramButtonSelector);
            actions.MoveToElement(instagramButton).Perform();
            instagramButton.Click();
        }

        public void ChangeToUkrainian()
        {
            IWebElement ukrainianButton = webDriver.FindElement(ukrainianSelector);

            ukrainianButton.Click();
        }

        public void OpenContactPage()
        {
            IWebElement contactButton = webDriver.FindElement(contactButtonSelector);
            contactButton.Click();
        }

        public void OpenHowWeDoItPage()
        {
            IWebElement contactButton = webDriver.FindElement(howWeDoItButtonSelector);
            contactButton.Click();
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
        }

        public bool CheckTitle()
        {
            return title.Equals(GetTitle());
        }

        public void OpenBlogPage()
        {
            Actions actions = new Actions(webDriver);
            IWebElement careerButton = webDriver.FindElement(careerButtonSelector);
            IWebElement blogButton = webDriver.FindElement(blogButtonSelector);
            actions.MoveToElement(careerButton).Perform();
            blogButton.Click();
        }
    }
}
