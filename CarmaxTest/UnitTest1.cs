using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using System.Text.RegularExpressions;
using System.Threading;

namespace CarmaxTest
{
    [TestClass]
    public class UnitTest1
    {

        //Creates the refernce for our browser. In this case using Internet Exploder.
        IWebDriver driver = new InternetExplorerDriver(@"C:\Users\Perry\Desktop");

        static void Main(string[] args)
        {

        }
         [SetUp]
        public void Initialize()
        {
            //Navigate to Carfax
            driver.Navigate().GoToUrl("http://www.carmax.com/");
            Console.WriteLine("Opened URL");
        }

        [TestMethod]
        public void TestMethod1() //Execute
        {
            //Navigate to Carfax
            driver.Navigate().GoToUrl("http://www.carmax.com/");
            Console.WriteLine("Opened URL");
            //Finds the Search box
            IWebElement searchInput = driver.FindElement(By.Id("search"));
          
            //Enters you text you want in the search box
            searchInput.SendKeys("jeep");
            //Clicks enter to what ever you put in the search box
            searchInput.SendKeys(Keys.Enter);
            //Click the radius and zip code

            //driver.FindElement(By.Id("dLabel")).FindElement(By.Id("dropdown-menu")).Click();
            //driver.FindElement(By.LinkText("75 miles")).Click();

            //IWebElement dropDownListBox = driver.FindElement(By.Id("dLabel"));
            //SelectElement clickThis = new SelectElement(dropDownListBox);
            //clickThis.SelectByText("500 miles");

            // IWebElement dropDownListBox = driver.FindElement(By.Id("selectedDistanceDesc"));

            //new SelectElement(driver.FindElement(By.Id("selectedDistanceDesc"))).SelectByIndex(3);

            //SelectElement clickThis = new SelectElement(dropDownListBox);
            //clickThis.SelectByText("500 miles");

            //
            //driver.FindElement(By.Name("dLabel")).Click();


            //driver.FindElement(By.Id("dLabel")).Click();
            //driver.FindElement(By.LinkText("500 miles")).Click();
            //driver.FindElement(By.Id("zip")).Clear();
            //driver.FindElement(By.Id("zip")).SendKeys("76513");
            //driver.FindElement(By.Id("distanceSubmit")).Click();
            //Clicking the milage drop down
            //driver.FindElement(By.Id("mileageFilter"));//.SelectByText("30,000 or less");
            //driver.FindElement(By.Id("30,000 or less"));

            driver.FindElement(By.XPath("//button[contains(.,'    any distance    ')]"));

            //driver.FindElement(By.XPath("//Input[@id='r_780]"));

            //IWebElement checkBox1;
            //IWebElement checkBox3;



            //checkBox1 = driver.FindElement(By.CssSelector("input[value='cb1']"));
           // checkBox3 = driver.FindElement(By.CssSelector("input[value='cb3']"));

          //  if (!checkBox1.isSelected())
           // {
          //      checkBox1.click();
           // }

            //checkBox3 is selected by default
          //  if (checkBox3.isSelected())
          //  {
           //     checkBox3.click();
          //  }

          //  driver.FindElement(By.Id("r_780")).Click();
          //  driver.FindElement(By.Id("r_819")).Click();
            
            //SoftVerifier.Equals("http://img2.carmax.com/image/10934098/216/162");
            

            Console.WriteLine("Executed Test");
        }

        private class SoftVerifier
        {
            private StringBuilder verificationErrors;

            public SoftVerifier()
            {
                verificationErrors = new StringBuilder();
            }

            public void VerifyElementIsPresent(IWebElement element)
            {
                if (!element.Displayed)
                {
                    verificationErrors.Append("Element was not displayed");
                }
            }
        }

         [TearDown]
        public void CleanUp()
        {
            driver.Close();
            Console.WriteLine("Closed Browser");
        }

    }
}




