
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Linq;
using Xunit;

//TEST - Verify is user can successfully log in
// Open Browser using chrome
IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();

// Open turnup portal
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
// Identify Username textbox and enter valid username
IWebElement username = driver.FindElement(By.Id("UserName"));
username.SendKeys("hari");

// Identify Password textbox and enter valid password
IWebElement password = driver.FindElement(By.Id("Password"));
password.SendKeys("123123");

// Click log in button
IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
loginButton.Click();

// Validate if user is logged in
IWebElement loggedInText = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));

if (loggedInText.Text == "Hello hari!")
{
    Console.WriteLine("User is logged in");
}
else
{
    Console.WriteLine("User is not logged in");
}