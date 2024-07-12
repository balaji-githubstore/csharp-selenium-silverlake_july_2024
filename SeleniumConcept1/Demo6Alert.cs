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
    public class Demo5Alert
    {
        static void Mains(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://netbanking.hdfcbank.com/netbanking/IpinResetUsingOTP.htm";

            //click on Go
           // driver.FindElement(By.XPath("//img[@alt='Go']")).Click();

            WebDriverWait wait = new WebDriverWait(driver,TimeSpan.FromSeconds(20));
            wait.Timeout=TimeSpan.FromSeconds(30); //max time to check
            //default PollingInterval - 0.5s
            //wait.PollingInterval = TimeSpan.FromSeconds(5); //how frequently checks for the condition

            wait.Until(x=>x.SwitchTo().Alert());

            //wait.PollingInterval = TimeSpan.FromSeconds(2);
            //wait.Until(x => x.FindElement(By.XPath(""))).SendKeys("hello");

            String actualAlertText = driver.SwitchTo().Alert().Text;

            Console.WriteLine(actualAlertText);

            driver.SwitchTo().Alert().Accept();
        }
    }
}
