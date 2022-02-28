using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecflowNetCoreDemo.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecflowNetCoreDemo.Steps
{
    [Binding]
    class LoginSteps
    {
        // Anti context Injection code
        LoginPage loginPage = null;

        //steps definition
        [Given(@"I launch the application")]
        public void GivenILaunchTheApplication()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://eaapp.somee.com");
            driver.Manage().Window.Maximize();
            loginPage = new LoginPage(driver);
        }

        [Given(@"I click the login link")]
        public void GivenIClickTheLoginLink()
        {
            loginPage.ClickLogin();
        }

        [Given(@"I enter the\tfollowing details")]
        public void GivenIEnterTheFollowingDetails(Table table)
        {
            dynamic data = table.CreateDynamicInstance();

            loginPage.Login((string)data.UserName, (string)data.Password); 
        }

        [Given(@"I click login button")]
        public void GivenIClickLoginButton()
        {
            loginPage.ClickLoginButton();
        }

        [Then(@"I should see Employee details link")]
        public void ThenIShouldSeeEmployeeDetailsLink()
        {
            Assert.IsTrue(loginPage.IsEmployeeDetailsExists());
         
        }

    }
}
