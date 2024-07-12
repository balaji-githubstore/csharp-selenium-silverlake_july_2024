using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcept1
{
    public class Demo2FbLogin
    {
        static void Main1(string[] args)
        {
            IWebDriver driver=new ChromeDriver();
            driver.Url = "https://www.facebook.com/";

            driver.FindElement(By.Id("email")).SendKeys("hello1223452@gmail.com");

            driver.FindElement(By.Id("pass")).SendKeys("welome233");

            //click on login
        }
    }
}
