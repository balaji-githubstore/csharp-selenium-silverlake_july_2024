using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.Extensions;

namespace SeleniumConcept1
{
    public class Demo7JS
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://www.citibank.co.in/ssjsps/forgetuseridmidssi.jsp";

            driver.FindElement(By.LinkText("select your product type")).Click();
            driver.FindElement(By.LinkText("Credit Card")).Click();

            //approach 1 - not working
            driver.FindElement(By.Id("bill-date-long")).SendKeys("17/06/1992");

            //approach 2 - automate calendar
            //select year 
            //select month
            //click on 17

            //approach 3 //js
            driver.ExecuteJavaScript("document.querySelector('#bill-date-long').value='17/06/1992'");


            //approach 4 //js and WebElement
            IWebElement element1= driver.FindElement(By.XPath("//input[@id='bill-date-long']"));

            driver.ExecuteJavaScript("arguments[0].value='17/06/1999'",element1);
        }
    }
}
