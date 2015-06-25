using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;


namespace CarMaxTests
{
    [TestClass]
    public class UnitTest1
    {
        private IWebDriver _driver;

        public UnitTest1()
        {


        }

        [SetUp]
        public void Initialize()
        {

        }


        [TestMethod]
        public void TestMethod1()
        {
            //_driver = new InternetExplorerDriver(@".");

            _driver = new ChromeDriver(@".");

            //Navigate to Carfax
            _driver.Navigate().GoToUrl("http://www.carmax.com/");

            new WebDriverWait(_driver, TimeSpan.FromSeconds(15)).Until(ExpectedConditions.ElementExists((By.ClassName("page"))));

            Console.WriteLine("Opened URL");
            //Finds the Search box
            IWebElement searchInput = _driver.FindElement(By.Id("search"));

            //Enters you text you want in the search box
            searchInput.SendKeys("jeep");

            //Clicks enter to what ever you put in the search box
            searchInput.SendKeys(Keys.Enter);

            // Car Features


            //********************* Exterior Color Div Click Down ********
            //*************Use Code to as a div drop down
            _driver.FindElement(By.Id("Exterior Color")).Click();

            //Exterior Color Choice
            // Color set to first choice black
            IWebElement ExteriorColor = _driver.FindElement(By.XPath(".//*[@id='r_4294963167']"));
            ExteriorColor.Click();


            //20inch plus wheels option box
            _driver.FindElement(By.Id("r_811")).Click();
            //Air Conditioning option box
            _driver.FindElement(By.Id("r_780")).Click();
            //Automatic Transmisson
            _driver.FindElement(By.Id("r_781")).Click();


            //Mile radius and Area code check boxes
            //IWebElement dropDownListBox = _driver.FindElement(By.Id("selectedDistanceDesc"));
            IWebElement drop = _driver.FindElement(By.Id("dLabel"));
            drop.Click();
            //Selected Distance
            _driver.FindElement(By.CssSelector("#distance > li:nth-child(5) > a")).Click();
            //testing zip
            IWebElement Zip = _driver.FindElement(By.CssSelector("#zip"));
            Zip.SendKeys("76504");
            Zip.SendKeys(Keys.Enter);

            _driver.FindElement(By.Id("zip")).Clear();
            _driver.FindElement(By.Id("zip")).SendKeys("76504");

            //Update button
            _driver.FindElement(By.Id("distanceSubmit")).Click();

            string value = _driver.FindElement(By.CssSelector("#resultsHeader > h1")).Text;

            Console.WriteLine(String.Format("{0}", value));


            // Checking to see correct cars found
            Assert.AreEqual("1 cars found", value);

            Console.WriteLine("Executed Test");



        }
    }
}
