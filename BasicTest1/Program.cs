using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://demo.guru99.com/test/guru99home/";
            driver.Manage().Window.Maximize();

            /*IWebElement element = driver.FindElement(By.XPath("//*[@id='navbar-brand-centered']/ul/li[2]"));
            element.Click();*/

            /*IWebElement emailBox = driver.FindElement(By.XPath(".//*[@id='philadelphia-field-email']"));
            IWebElement submitBtn = driver.FindElement(By.XPath(".//*[@id='philadelphia-field-submit']"));
            emailBox.SendKeys("abc@abc.com");
            submitBtn.Click();
            // Alart Handle
            driver.SwitchTo().Alert().Accept();*/

            //Select Item from dropdown
            /*IWebElement course = driver.FindElement(By.XPath(".//*[@id='awf_field-91977689']"));
            var selectItem = new SelectElement(course);
            selectItem.SelectByIndex(5);*/

            /* string clickPath = ".//*[@class='item119']/a";
            IWebElement elementHover = driver.FindElement(By.XPath(".//*[@class='menu-block']/ul/li[2]/a"));
            IWebElement elementClick = driver.FindElement(By.XPath(clickPath));

            //hover on element
            Actions action = new Actions(driver);
            action.MoveToElement(elementHover).Perform();

            // Explicit wait example
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(clickPath)));

            elementClick.Click();*/

            

            driver.Close();
        }
    }
}
