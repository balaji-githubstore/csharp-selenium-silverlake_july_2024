using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcept1
{
    public class Demo4Tabs
    {
        static void Main1(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://www.db4free.net/";

            //click on phpMyAdmin »
            //b[contains(text(),'phpMy')]
            driver.FindElement(By.PartialLinkText("phpMyAdmin")).Click();

            //switch to 2nd tab
            driver.SwitchTo().Window(driver.WindowHandles[1]);

            driver.FindElement(By.Id("input_username")).SendKeys("admin");
            //enter password as admin123
            //click on log in


            driver.Close(); //check what's happening? 

            //switch to 1st tab
            driver.SwitchTo().Window(driver.WindowHandles[0]);

            Console.WriteLine(driver.Title);


            driver.Quit();

        }
    }
}
