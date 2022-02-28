using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecflowNetCoreDemo.Pages
{
    public class LoginPage
    {
        public IWebDriver driver { get; } 

        public LoginPage(IWebDriver Webdriver)
        {
            driver = Webdriver;
        }

        //UI Elements
        public IWebElement lnkLogin => driver.FindElement(By.LinkText("Login"));
        public IWebElement txtUserName => driver.FindElement(By.Name("UserName"));
        public IWebElement txtPassword => driver.FindElement(By.Name("Password"));
        public IWebElement btnLogin => driver.FindElement(By.CssSelector(".btn-default"));
        public IWebElement lnkEmployeeDetails => driver.FindElement(By.LinkText("Employee Details"));

        public void ClickLogin() => lnkLogin.Click();

        public void Login(string userName, string password)
        {
            txtUserName.SendKeys(userName);
            txtPassword.SendKeys(password);
        }

        public void ClickLoginButton() => btnLogin.Click();

        public bool IsEmployeeDetailsExists() => lnkEmployeeDetails.Displayed;
        
    }
}
