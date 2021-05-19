using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Selenium_homework.page_objects;
using System;
using TechTalk.SpecFlow;

namespace Selenium_homework.features
{
   [Binding]
    public class NavigationBarUITestSteps
    {
        private const string ChromeDriverDirectory = "D:\\СhromeDriver";
        IWebDriver webDriver;

        MainPage mainPage;
        BlogPage blogPage;
        HowWeDoItPage howWeDoItPage;
        ContactPage contactPage;
        InstagramPage instagramPage;


        [Before]
        public void init()
        {      
            webDriver = new ChromeDriver(ChromeDriverDirectory);
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            webDriver.Manage().Window.Maximize();
         
            mainPage = new MainPage(webDriver);
            blogPage = new BlogPage(webDriver);
            howWeDoItPage = new HowWeDoItPage(webDriver);
            contactPage = new ContactPage(webDriver);
            instagramPage = new InstagramPage(webDriver);
        }

        [After]
        public void stopDriver()
        {
            webDriver.Close();
        }


        [Given(@"User has opened main page")]
        public void GivenUserHasOpenedMainPage()
        {
            mainPage.OpenPage("https://www.epam.com/");
        }
        
        [When(@"User opens blog page")]
        public void WhenUserOpensBlogPage()
        {
            mainPage.OpenBlogPage();
        }
        
        [When(@"User clicks how we do it button")]
        public void WhenUserClicksHowWeDoItButton()
        {
            mainPage.OpenHowWeDoItPage();
        }
        
        [When(@"User clicks contact selection button")]
        public void WhenUserClicksContactSelectionButton()
        {
            mainPage.ClickSelectorButton();
        }
        
        [When(@"Choose ukrainian")]
        public void WhenChooseUkrainian()
        {
            mainPage.ChangeToUkrainian(); 
        }
        
        [When(@"User clicks contact us button")]
        public void WhenUserClicksContactUsButton()
        {
            mainPage.OpenContactPage();
        }
        
        [When(@"User clicks home page button")]
        public void WhenUserClicksHomePageButton()
        {
            howWeDoItPage.OpenHomePage();
        }
        
        [Then(@"Blog page opens")]
        public void ThenBlogPageOpens()
        {
            Assert.True(blogPage.CheckTitle());
        }
        
        [Then(@"User sees Greetings, Innovators!")]
        public void ThenUserSeesGreetingsInnovators()
        {
            string centerTitle = "Greetings, Innovators!";
            Assert.True(blogPage.CheckCenterTitle(centerTitle));
        }
        
        [Then(@"How we do it page opens")]
        public void ThenHowWeDoItPageOpens()
        {
            Assert.True(howWeDoItPage.CheckTitle());
        }
        
        [Then(@"User see ukrainian main page")]
        public void ThenUserSeeUkrainianMainPage()
        {
            Assert.False(contactPage.CheckTitle());
        }
        
        [Then(@"Contact page opens")]
        public void ThenContactPageOpens()
        {
            Assert.True(contactPage.CheckTitle());
        }
        
        [Then(@"User backs to home page")]
        public void ThenUserBacksToHomePage()
        {
            Assert.False(mainPage.CheckTitle());
        }
        
        [Then(@"User clicks search button")]
        public void ThenUserClicksSearchButton()
        {
            mainPage.ClickSearchButton();
        }
        
        [Then(@"User writes Blockchain")]
        public void ThenUserWritesBlockchain()
        {
            mainPage.AddText();
        }
        
        [Then(@"User clicks find button")]
        public void ThenUserClicksFindButton()
        {
            mainPage.AcceptFind();
        }
        
        [Then(@"User sees result")]
        public void ThenUserSeesResult()
        {
            Assert.True(webDriver.Url.Equals("https://www.epam.com/search?q=Blockchain"));
        }
    }
}
