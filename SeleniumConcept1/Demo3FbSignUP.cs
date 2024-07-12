using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace SeleniumConcept1
{
    public class Demo3FbSignUP
    {
        static void Main1(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(20);

            driver.Url = "https://www.facebook.com/";

            driver.FindElement(By.XPath("(//span[text()='Allow all cookies'])[2]")).Click();

            //click on Create New Account
            driver.FindElement(By.LinkText("Create new account")).Click();

            //enter firstname as john
            driver.FindElement(By.Name("firstname")).SendKeys("jack");
            driver.FindElement(By.Name("lastname")).SendKeys("wick");

            driver.FindElement(By.Id("password_step_input")).SendKeys("john123");

            driver.FindElement(By.XPath("//input[@value='-1']")).Click();

            SelectElement selectDay = new SelectElement(driver.FindElement(By.Id("day")));
            selectDay.SelectByText("17");

            SelectElement selectMonth = new SelectElement(driver.FindElement(By.Id("month")));
            selectMonth.SelectByText("Jun");

            //select year as 1992
        }
    }
}







