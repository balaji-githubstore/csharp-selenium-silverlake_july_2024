using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcept1
{
    public class Demo5Frame
    {
        static void Main1(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://netbanking.hdfcbank.com/netbanking/";

            //enter userid as jack123
            driver.FindElement(By.Name("fldLoginUserId")).SendKeys("hello123");

            //click on Continue
            //linktext or partial link text --> give character font as per UI
            //xpath - font as per html 
            driver.FindElement(By.LinkText("CONTINUE")).Click();

            //switch to main html
            driver.SwitchTo().DefaultContent();


            driver.Quit();
        }
    }
}
