using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcept1
{
    public class Demo1LaunchBrowser
    {
        static void Main1(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

            //set property
            driver.Url = "https://www.facebook.com/";

            String actualTitle=driver.Title;
            Console.WriteLine(actualTitle);

            Console.WriteLine(driver.Title);

            //get property
            Console.WriteLine(driver.Url);

            //Use PageSource property and print it
            Console.WriteLine(driver.PageSource);


        }
    }
}
