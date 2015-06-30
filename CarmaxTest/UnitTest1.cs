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






            //********************* Div Click Down ********
            //*************Use Code to as a div drop down
            _driver.FindElement(By.Id("Exterior Color")).Click();

            //**********************Exterior Color Choice***************

            // Color set to first choice black
            IWebElement ExteriorColorBlack = _driver.FindElement(By.XPath(".//*[@id='r_4294963167']"));
            ExteriorColorBlack.Click();
            //Color Choice Blue
            //IWebElement ExteriorColorBlue = _driver.FindElement(By.XPath(".//*[@id='r_4294963171']"));
            //ExteriorColorBlue.Click();
            //IWebElement ExteriorColorGreen = _driver.FindElement(By.XPath(".//*[@id='r_4294963122']"));
            //ExteriorColorGreen.Click();
            //IWebElement ExteriorColorRed = _driver.FindElement(By.XPath(".//*[@id='r_4294963166']"));
            //ExteriorColorRed.Click();
            //IWebElement ExteriorColorSilver = _driver.FindElement(By.XPath(".//*[@id='r_4294963203']"));
            //ExteriorColorSilver.Click();
            //IWebElement ExteriorColorWhite = _driver.FindElement(By.XPath(".//*[@id='r_4294963172']"));
            //ExteriorColorWhite.Click();

            //***********************Car Features*****************
            // Does not need a Div drop down

            //20inch plus wheels option box
            _driver.FindElement(By.Id("r_811")).Click();
            //4WD/AWD
            //_driver.FindElement(By.Id("r_788")).Click();
            //Air Conditioning option box
            //_driver.FindElement(By.Id("r_780")).Click();
            //Automatic Transmisson
            //_driver.FindElement(By.Id("r_781")).Click();
            //AM/FM Radio
            //_driver.FindElement(By.Id("r_819")).Click();
            //Premiun Sound
            //_driver.FindElement(By.Id("r_865")).Click();
            //Tow Hitch
            //_driver.FindElement(By.Id("r_778")).Click();

            //********************* Div Click Down ********
            //*************Use Code to as a div drop down
            //_driver.FindElement(By.Id("Interior Color")).Click();

            //**************Interior Features**********
            //IWebElement InteriorColorBlack = _driver.FindElement(By.XPath(".//*[@id='r_4294961961']"));
            //InteriorColorBlack.Click();
            //IWebElement InteriorColorBlue = _driver.FindElement(By.XPath(".//*[@id='r_4294961959']"));
            //InteriorColorBlue.Click();
            //IWebElement InteriorColorGrey = _driver.FindElement(By.XPath(".//*[@id='r_4294961965']"));
            //InteriorColorGrey.Click();
            //IWebElement InteriorColorTan = _driver.FindElement(By.XPath(".//*[@id='r_4294961963']"));
            //InteriorColorTan.Click();


            //********************* Div Click Down ********
            //*************Use Code to as a div drop down
            //_driver.FindElement(By.Id("MPG highway")).Click();

            //********************MPG Highway*************

            //IWebElement MPG15 = _driver.FindElement(By.XPath(".//*[@id='r_275']"));
            //MPG15.Click();
            //IWebElement MPG20 = _driver.FindElement(By.XPath(".//*[@id='r_276']"));
            //MPG20.Click();
            //IWebElement MPG25 = _driver.FindElement(By.XPath(".//*[@id='r_277']"));
            //MPG25.Click();
            //IWebElement MPG30 = _driver.FindElement(By.XPath(".//*[@id='r_278']"));
            //MPG30.Click();

            //********************* Div Click Down ********
            //*************Use Code to as a div drop down
            //_driver.FindElement(By.Id("Transmission")).Click();

            //********************Transmission*************
            //IWebElement auto = _driver.FindElement(By.XPath(".//*[@id='r_282']"));
            //auto.Click();
            //IWebElement manual = _driver.FindElement(By.XPath(".//*[@id='r_283']"));
            //manual.Click();

            //*************Mile radius and Area code check boxes************

            IWebElement drop = _driver.FindElement(By.Id("dLabel"));
            drop.Click();
            //************Selected Distance
            // Set to 250 miles
            _driver.FindElement(By.CssSelector("#distance > li:nth-child(5) > a")).Click();
            //*****************testing zip
            IWebElement Zip = _driver.FindElement(By.CssSelector("#zip"));
            Zip.SendKeys("76504");
            Zip.SendKeys(Keys.Enter);
            Zip.Click();

            _driver.FindElement(By.Id("zip")).Clear();
            _driver.FindElement(By.Id("zip")).SendKeys("76504");

            //****************Update button
            _driver.FindElement(By.Id("distanceSubmit")).Click();

            string value = _driver.FindElement(By.CssSelector("#resultsHeader > h1")).Text;

            Console.WriteLine(String.Format("{0}", value));

            //*************Selects first car in list ********WORKS*****
            //_driver.FindElement(By.XPath("//*[@id='resultsList']/div[1]/div[3]/div[1]")).Click();


            //Working on this segement
            ////Working Code to always select $32,998*

            //_driver.FindElement(By.Name("//tr[td//a[@value='Select']]/td/a[contains(text(),'$32,998*')]")).Click();

            //WebElement PriceLink = _driver.FindElement(By. ("$32,998*"));

            //var priceClick = new SelectElement(_driver.FindElement(By.XPath(".//*[@id='r_4294963167']")));
            //priceClick.SelectByText("$32,998");

            var priceClick = _driver.FindElement(By.XPath(".//*[@id='r_4294963167']"));
            // priceClick.Click("32998");

            //priceClick.Click("$32,998");

            //IWebElement ExteriorColor = _driver.FindElement(By.XPath(".//*[@id='r_4294963167']"));
            //ExteriorColor.Click();
            //IWebElement Price = _driver.FindElements(By.XPath("//a[contains(text(),'$32,988*')"));


            //_driver.FindElement(By.PartialLinkText("//a[contains(text(),'$32,988*')")).Click();

            //_driver.FindElement(By.PartialLinkText("//*[contains(text(), '$32,988*')]")).Click();


            //****************Checking to see correct cars found*****************
            Assert.AreEqual("1 cars found", value);

            Console.WriteLine("Executed Test");



            _driver.Dispose();

        }


    }

}

